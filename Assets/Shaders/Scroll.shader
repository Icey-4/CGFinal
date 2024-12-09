Shader "Custom/Scroll"
{
    Properties
    {
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        _ScrollX ("Scroll X", Range(-5, 5)) = 1
        _ScrollY ("Scroll Y", Range(-5, 5)) = 1
    }
    SubShader
    {
        CGPROGRAM
        // Physically based Standard lighting model, and enable shadows on all light types
        #pragma surface surf Lambert

        sampler2D _MainTex;
        float _ScrollX;
        float _ScrollY;

        struct Input
        {
            float2 uv_MainTex;
        };

        void surf (Input IN, inout SurfaceOutput o)
        {
            _ScrollX *= _Time;
            _ScrollY *= _Time;
            float2 newuv = IN.uv_MainTex + float2(_ScrollX, _ScrollY);
            o.Albedo = tex2D (_MainTex, newuv);
        }
        ENDCG
    }
    FallBack "Diffuse"
}
