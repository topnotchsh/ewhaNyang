using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Android;

//이 스크립트는 main camera에 컴포넌트로 등록해야 정상 작동함
//이 스크립트가 정상작동되기 위해서는 nativetoolkit이라는 package설치 필요!
//한글로 주석달아둔 곳 말고는 수정할 필요 없을듯!
public enum gpsModes
{
    Unity3D,
    NativeToolkit,
    Off
}

public class GPSInteraction : MonoBehaviour
{
    public static GPSInteraction Instance { set; get; }

    [Header("Change Img")]
    public Image beforeImg;
    public Sprite afterImg;

    [HideInInspector]
    public double latitude;

    [HideInInspector]
    public double longitude;

    [HideInInspector]
    public double altitude;

    public float BodyHeight = 1.7f;

    [HideInInspector]
    public double distance;

    //TargetLat과 TargetLong은 스크립트가 아닌 유니티에서 입력하기!===========================================
    [Header("Target latitude")]
    public double TargetLat;

    [Header("Target longitude")]
    public double TargetLong;

    //dis는 Target좌표로부터 몇미터 이내에 있을때 인터렉션이 일어나게 할지를 의미함
    //dis도 스크립트가 아니라 유니티에서 직접 입력하기!
    //미터단위로 생각하면됨
    [Header("Distance From TargetLoc")]
    public int dis;
    //=========================================================================================================

    //인터렉션이 일어날 텍스트
    [Header("ShowDistance")]
    public Text ShowDistance;

    private bool GPS = true;

    //인터렉션이 일어날 버튼==============================================
    [Header("Interacting Target Button")]
    public Button InteractingButton;

    //[Header("Event Color")]
    public ColorBlock colorBlock;
    //====================================================================

    [Header("GPS Mode-Check Native Toolkit")]
    [Tooltip("Smartphone only")]
    public gpsModes gpsMode;

    //버튼 색 변화를 위해 필요한 renderer===================================
    //Renderer buttoncolor;
    //======================================================================

    public void Awake()
    {
        //GPS권한 묻기
        if (!Permission.HasUserAuthorizedPermission(Permission.FineLocation))
            Permission.RequestUserPermission(Permission.FineLocation);
    }

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;

        //Scene 넘어가도 상태 유지
        DontDestroyOnLoad(gameObject);

        //스크립트로 오브젝트를 변하게 하려면 이렇게 소속 경로와 객체를 연결해주기!
        
        InteractingButton = transform.Find("Canvas").Find("MainMapObject").Find("ButtonSet").Find("ecc").gameObject.GetComponent<Button>();
        ShowDistance = transform.Find("Canvas").Find("ShowDistance").gameObject.GetComponent<Text>();

        //스크립트로 오브젝트를 변하게 하려면 이렇게 enable을 true로 설정해줘야함!
        InteractingButton.enabled = true;
        ShowDistance.enabled = true;
        

        if (gpsMode == gpsModes.NativeToolkit)
        {
            // user wants NativeToolkit
            // check if this class exists in runtime 
            // before he use it, to prevent error
            bool classNativeToolkitExists = (null != Type.GetType("NativeToolkit"));
            if (classNativeToolkitExists)
            {
                // START NativeToolkit GPS Interface
                
                GPS = true;
            }
            else
            {
                //if not installed change to Unity3D GPS
                
                gpsMode = gpsModes.Unity3D;

            }
            if (gpsMode == gpsModes.Unity3D)
            {
                // START Unity3D  GPS Interface
                
                StartCoroutine(StartLocationService());
            }

        }

        //buttoncolor = gameObject.GetComponent<Renderer>();
    }

        // Update is called once per frame
     public void Update()
     {
         if (GPS)
         {

             if (gpsMode == gpsModes.NativeToolkit)
             {
                  latitude = NativeToolkit.GetLatitude();
                  longitude = NativeToolkit.GetLongitude();
                  altitude = BodyHeight;

            }
             if (gpsMode == gpsModes.Unity3D)
             {
                  latitude = (double)Input.location.lastData.latitude;
                  longitude = (double)Input.location.lastData.longitude;
                  altitude = BodyHeight;

            }
         }

         double DisFromTarget(double TarLat, double TarLong, double Lat, double Long)
        {
            double distance=0.0d;
            double TarLat_Rad = TarLat * Mathf.Deg2Rad;
            double TarLong_Rad = TarLong * Mathf.Deg2Rad;

            double Lat_Rad = Lat * Mathf.Deg2Rad;
            double Long_Rad = Long * Mathf.Deg2Rad;

            if ((TarLat_Rad == Lat_Rad) && (TarLong_Rad == Long_Rad)) return 0;
            else
            {
                double theta = TarLong_Rad - Long_Rad;
                distance = Math.Sin(TarLat_Rad) * Math.Sin(Lat_Rad) + Math.Cos(TarLat_Rad) * Math.Cos(Lat_Rad) * Math.Cos(theta);
                distance = Math.Acos(distance);
                distance = distance * Mathf.Rad2Deg;
                distance = distance * 60d * 1.1515d;
                distance = distance * 1.609344d * 1000d;
                return distance;
            }
        }

        //여기에 원하는 인터렉션 입력===========================================================
        //정상적으로 작동되기 위해서 네가지 확인하기!
        //1. transform.find로 대상 객체를 스크립트로 잘 연결했는지
        //2. 대상 객체를 enable값을 true로 설정했는지
        //3. GPSMode가 NativeToolkit인지
        //4. awake이전에 pulbic으로 대상 객체를 선언해줬는지

        //타겟 좌표로부터 거리 실시간 출력
        ShowDistance.text = DisFromTarget(latitude, longitude, TargetLat, TargetLong).ToString();

        //(TargetLat, TargetLong)으로부터 dis 미터 이내에 있을때
        if ((DisFromTarget(latitude, longitude, TargetLat, TargetLong)) < dis)
        {

            //버튼 색 변환
            
            beforeImg.sprite = afterImg;
         }
        //========================================================================================
     }

    private IEnumerator StartLocationService()
    {
        if (!Input.location.isEnabledByUser)
        {
            
            yield break;
        }
        Input.location.Start(0.1f, 0.1f);

        int maxWait = 20;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
        {
            yield return new WaitForSeconds(1);
            maxWait--;
        }
        if (maxWait <= 0)
        {
            
            yield break;
        }
        if (Input.location.status == LocationServiceStatus.Failed)
        {
            
            yield break;

            latitude = (double)Input.location.lastData.latitude;
            longitude = (double)Input.location.lastData.longitude;
            GPS = true;
            
            yield break;
        }

    }
    
   
    
}

