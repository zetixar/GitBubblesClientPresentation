Shader "Custom/MinimapMaskShader"
{
    Properties {
        _MainTex ("Base (RGB)", 2D) = "white" {}
        _Alpha ("Alpha (A)", 2D) = "white" {}
    }
    SubShader {
        Tags { "RenderType" = "Transparent" "Queue" = "Transparent"}
       
        ZWrite Off
       
        Blend SrcAlpha OneMinusSrcAlpha
        ColorMask RGB
       
        Pass {
            SetTexture[_MainTex] {
                Combine texture
            }
            SetTexture[_Alpha] {
                Combine previous, texture
            }
        }
    }



//   Properties
//   {
//      _MainTex ("Base (RGB)", 2D) = "white" {}
//      _Mask ("Culling Mask", 2D) = "white" {}
//      _Cutoff ("Alpha cutoff", Range (0,1)) = 0.1
//   }
//   SubShader
//   {
//      Tags {"Queue"="Transparent"}
//      Lighting Off
//      ZWrite Off
//      Blend SrcAlpha OneMinusSrcAlpha
//      AlphaTest GEqual [_Cutoff]
//      Pass
//      {
//         SetTexture [_Mask] {combine texture}
//         SetTexture [_MainTex] {combine texture, previous}
//      }
//   }




//	Properties
//	{
//		_MainTex ("Texture", 2D) = "white" {}
//		_Mask ("Mask Texture", 2D) = "white" {}
//	}
//	SubShader
//	{
//		Tags { "Queue"="Transparent" }
//		Lighting on
//		ZWrite off
//		Blend SrcAlpha OneMinusSrcAlpha
//
//		Pass
//		{
//			SetTexture [_Mask] {combine texture}
//			SetTexture [_MainTex] {combine texture, previous}
//		}
//	}
}