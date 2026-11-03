namespace UnityEngine.LowLevelPhysics2D;

[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x2000069")]
internal static class PhysicsWorldRenderer
{
	[Token(Token = "0x200006A")]
	private struct DrawerGroup : IDisposable
	{
		[Token(Token = "0x200006B")]
		private abstract class BaseDrawer : IDisposable
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400021B")]
			private bool m_Disposed; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x400021C")]
			protected Mesh m_Mesh; //Field offset: 0x18
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x400021D")]
			protected GraphicsBuffer m_GraphicsBuffer; //Field offset: 0x20
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x400021E")]
			protected IndirectDrawIndexedArgs[] m_CommandData; //Field offset: 0x28
			[FieldOffset(Offset = "0x30")]
			[Token(Token = "0x400021F")]
			protected ComputeBuffer m_ElementBuffer; //Field offset: 0x30
			[FieldOffset(Offset = "0x38")]
			[Token(Token = "0x4000220")]
			protected Material m_ShaderMaterial; //Field offset: 0x38
			[FieldOffset(Offset = "0x40")]
			[Token(Token = "0x4000221")]
			protected MaterialPropertyBlock m_ShaderMaterialPropertyBlock; //Field offset: 0x40
			[FieldOffset(Offset = "0x48")]
			[Token(Token = "0x4000222")]
			protected readonly Bounds m_CullingBounds; //Field offset: 0x48
			[FieldOffset(Offset = "0x60")]
			[Token(Token = "0x4000223")]
			protected readonly int m_ElementBufferShaderProperty; //Field offset: 0x60
			[FieldOffset(Offset = "0x64")]
			[Token(Token = "0x4000224")]
			protected readonly int m_TransformPlaneShaderProperty; //Field offset: 0x64
			[FieldOffset(Offset = "0x68")]
			[Token(Token = "0x4000225")]
			protected readonly int m_ThicknessShaderProperty; //Field offset: 0x68
			[FieldOffset(Offset = "0x6C")]
			[Token(Token = "0x4000226")]
			protected readonly int m_FillAlphaShaderProperty; //Field offset: 0x6C

			[Address(RVA = "0x31221A0", Offset = "0x31215A0", Length = "0x219")]
			[Token(Token = "0x60001FB")]
			protected BaseDrawer() { }

			[Address(RVA = "0x3121BF0", Offset = "0x3120FF0", Length = "0x15F")]
			[Token(Token = "0x60001F9")]
			public override void Dispose() { }

			[Token(Token = "0x60001FA")]
			public abstract void Draw(CommandBuffer rendererCommandBuffer, ref DrawResults drawResults, float thickness, float fillAlpha, TransformPlane transformPlane, int drawCapacity) { }

			[Address(RVA = "0x3121D50", Offset = "0x3121150", Length = "0x441")]
			[Token(Token = "0x60001F8")]
			protected Mesh GetMesh() { }

		}

		[Token(Token = "0x200006E")]
		private sealed class CapsuleGeometryDrawer : BaseDrawer
		{

			[Address(RVA = "0x3122CC0", Offset = "0x31220C0", Length = "0xA4")]
			[Token(Token = "0x6000200")]
			public CapsuleGeometryDrawer() { }

			[Address(RVA = "0x3122A10", Offset = "0x3121E10", Length = "0x2AE")]
			[Token(Token = "0x6000201")]
			public virtual void Draw(CommandBuffer rendererCommandBuffer, ref DrawResults drawResults, float thickness, float fillAlpha, TransformPlane transformPlane, int drawCapacity) { }

		}

		[Token(Token = "0x200006D")]
		private sealed class CircleGeometryDrawer : BaseDrawer
		{

			[Address(RVA = "0x31231D0", Offset = "0x31225D0", Length = "0xA4")]
			[Token(Token = "0x60001FE")]
			public CircleGeometryDrawer() { }

			[Address(RVA = "0x3122F20", Offset = "0x3122320", Length = "0x2AE")]
			[Token(Token = "0x60001FF")]
			public virtual void Draw(CommandBuffer rendererCommandBuffer, ref DrawResults drawResults, float thickness, float fillAlpha, TransformPlane transformPlane, int drawCapacity) { }

		}

		[Token(Token = "0x200006F")]
		private sealed class LineDrawer : BaseDrawer
		{

			[Address(RVA = "0x3126AB0", Offset = "0x3125EB0", Length = "0xA4")]
			[Token(Token = "0x6000202")]
			public LineDrawer() { }

			[Address(RVA = "0x3126820", Offset = "0x3125C20", Length = "0x28D")]
			[Token(Token = "0x6000203")]
			public virtual void Draw(CommandBuffer rendererCommandBuffer, ref DrawResults drawResults, float thickness, float fillAlpha, TransformPlane transformPlane, int drawCapacity) { }

		}

		[Token(Token = "0x2000070")]
		private sealed class PointDrawer : BaseDrawer
		{

			[Address(RVA = "0x3131AE0", Offset = "0x3130EE0", Length = "0xA4")]
			[Token(Token = "0x6000204")]
			public PointDrawer() { }

			[Address(RVA = "0x3131850", Offset = "0x3130C50", Length = "0x28D")]
			[Token(Token = "0x6000205")]
			public virtual void Draw(CommandBuffer rendererCommandBuffer, ref DrawResults drawResults, float thickness, float fillAlpha, TransformPlane transformPlane, int drawCapacity) { }

		}

		[Token(Token = "0x200006C")]
		private sealed class PolygonGeometryDrawer : BaseDrawer
		{

			[Address(RVA = "0x31325C0", Offset = "0x31319C0", Length = "0xA4")]
			[Token(Token = "0x60001FC")]
			public PolygonGeometryDrawer() { }

			[Address(RVA = "0x3132310", Offset = "0x3131710", Length = "0x2AD")]
			[Token(Token = "0x60001FD")]
			public virtual void Draw(CommandBuffer rendererCommandBuffer, ref DrawResults drawResults, float thickness, float fillAlpha, TransformPlane transformPlane, int drawCapacity) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400021A")]
		private BaseDrawer[] m_Drawers; //Field offset: 0x0

		[Token(Token = "0x17000092")]
		public bool IsValid
		{
			[Address(RVA = "0x2096430", Offset = "0x2095830", Length = "0x8")]
			[IsReadOnly]
			[Token(Token = "0x60001F5")]
			 get { } //Length: 8
		}

		[Address(RVA = "0x3125580", Offset = "0x3124980", Length = "0x1E7")]
		[Token(Token = "0x60001F7")]
		public override void Dispose() { }

		[Address(RVA = "0x3125770", Offset = "0x3124B70", Length = "0x5E5")]
		[Token(Token = "0x60001F6")]
		public void Draw(CommandBuffer rendererCommandBuffer, ref DrawResults drawResults, float thickness, float fillAlpha, TransformPlane transformPlane, int drawCapacity) { }

		[Address(RVA = "0x2096430", Offset = "0x2095830", Length = "0x8")]
		[IsReadOnly]
		[Token(Token = "0x60001F5")]
		public bool get_IsValid() { }

	}

	[Token(Token = "0x4000216")]
	private static bool s_IsInitialized; //Field offset: 0x0
	[Token(Token = "0x4000217")]
	private static bool s_UsingBIRP; //Field offset: 0x1
	[Token(Token = "0x4000218")]
	private static CommandBuffer s_RendererCommandBuffer; //Field offset: 0x8
	[Token(Token = "0x4000219")]
	private static DrawerGroup[] s_DrawerGroups; //Field offset: 0x10

	[Address(RVA = "0x312FE40", Offset = "0x312F240", Length = "0x1D0")]
	[Token(Token = "0x60001F2")]
	private static void BIRP_RenderAllWorlds(Camera camera) { }

	[Address(RVA = "0x3121B00", Offset = "0x3120F00", Length = "0xEF")]
	[Token(Token = "0x60001F0")]
	private static PhysicsAABB GetCameraViewAABB(Camera camera) { }

	[Address(RVA = "0x3130020", Offset = "0x312F420", Length = "0x260")]
	[RequiredByNativeCode]
	[Token(Token = "0x60001EE")]
	private static void InitializeRendering() { }

	[Address(RVA = "0x3130290", Offset = "0x312F690", Length = "0x2C")]
	[Token(Token = "0x60001F1")]
	private static bool IsCameraTypeValid(Camera camera) { }

	[Address(RVA = "0x3130460", Offset = "0x312F860", Length = "0x112")]
	[RequiredByNativeCode]
	[Token(Token = "0x60001F4")]
	private static void SendDrawResultsToCommandBuffer(PhysicsWorld physicsWorld, DrawResults drawResults, TransformPlane transformPlane, float thickness, float fillAlpha, int drawCapacity) { }

	[Address(RVA = "0x3130580", Offset = "0x312F980", Length = "0x284")]
	[RequiredByNativeCode]
	[Token(Token = "0x60001EF")]
	private static void ShutdownRendering() { }

	[Address(RVA = "0x31302C0", Offset = "0x312F6C0", Length = "0x194")]
	[Token(Token = "0x60001F3")]
	private static void SRP_RenderAllWorlds(ScriptableRenderContext context, Camera camera) { }

}

