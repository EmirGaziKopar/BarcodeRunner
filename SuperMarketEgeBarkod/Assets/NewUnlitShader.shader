Shader "Custom/HorizontalDistortion"
{
    Properties
    {
        _MainTex ("Sprite Texture", 2D) = "white" {}
        _Amount ("Distortion Amount", Range(0, 1)) = 0.1
    }
 
    SubShader
    {
        Tags { "Queue"="Transparent" "RenderType"="Transparent" }
        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
 
            struct appdata_t
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };
 
            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };
 
            float _Amount;
 
            v2f vert (appdata_t v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv + float2(_Amount * (v.uv.y - 0.5), 0);
                return o;
            }
 
            sampler2D _MainTex;
 
            half4 frag (v2f i) : SV_Target
            {
                half4 col = tex2D(_MainTex, i.uv);
                return col;
            }
            ENDCG
        }
    }
}
