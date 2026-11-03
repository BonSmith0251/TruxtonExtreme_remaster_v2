using System;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;
// Unity6 RenderGraph callback omitted in2023 URP16; original exported body was an empty stub.
using UnityEngine.Rendering.Universal;

namespace TXEKernel
{
	public class TXERendererFeatureCopyColor : ScriptableRendererFeature
	{
		[Serializable]
		public class Settings
		{
			public string textureName;

			public RenderPassEvent passEvent;

			[Header("CopyColor Downsample (1=Full, 2=Half, 4=Quarter)")]
			[Min(1f)]
			public int downsample;

			public bool forceEvenSize;
		}

		private class GrabPass : ScriptableRenderPass
		{
			private const string ProfilerTag = "TXERendererFeatureCopyColor";

			private readonly Settings _settings;

			private readonly int _texturePropertyId;

			public GrabPass(Settings settings)
			{
			}

			private void EnsureRenderTexture(int width, int height, GraphicsFormat format)
			{
			}

			// Unavailable in URP16: empty metadata stub RecordRenderGraph(RenderGraph, ContextContainer).

			public void Dispose()
			{
			}

			private static int DivRoundDown(int v, int div)
			{
				return 0;
			}

			private void GetDownsampledSize(int srcW, int srcH, out int w, out int h)
			{
				w = default;
				h = default;
			}
		}

		internal static RenderTexture s_SharedTexture;

		internal static RTHandle s_SharedTextureHandle;

		internal static string s_SharedTextureName;

		[SerializeField]
		private Settings settings;

		private GrabPass grabPass;

		public static RenderTexture SharedTexture => null;

		public static string SharedTextureName => null;

		public override void Create()
		{
		}

		[Obsolete("SetupRenderPasses is obsolete in RenderGraph, but kept for compatibility.")]
		public override void SetupRenderPasses(ScriptableRenderer renderer, in RenderingData renderingData)
		{
		}

		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}
	}
}
