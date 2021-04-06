Shader "Custom/Diffuse With Light Probes Original"
{
    Properties
    {
        [NoScaleOffset] _MainTex("Texture", 2D) = "white" {}
    }
        SubShader
    {
        Pass {
            Tags { "LightMode" = "ForwardBase" }
            CGPROGRAM
            #pragma vertex v
            #pragma fragment f
            #include "UnityCG.cginc"
            sampler2D _MainTex;
            struct v2f {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
                float3 worldPos : TEXCOORD2;
                float3 worldNormal : TEXCOORD3;
            };

            v2f v(appdata_base vertex_data) {
                v2f o;
                o.vertex = UnityObjectToClipPos(vertex_data.vertex);
                o.uv = vertex_data.texcoord;
                return o;
            }

            fixed4 f(v2f input_fragment) : SV_Target {
                fixed4 col = tex2D(_MainTex, input_fragment.uv);
                return col;
        }
        ENDCG
        }
    }
}
