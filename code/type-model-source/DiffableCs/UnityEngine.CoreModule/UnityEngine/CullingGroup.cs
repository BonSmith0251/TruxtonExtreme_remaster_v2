namespace UnityEngine;

[NativeHeader("Runtime/Export/Camera/CullingGroup.bindings.h")]
[Token(Token = "0x20000B1")]
public class CullingGroup : IDisposable
{
	[Token(Token = "0x20000B3")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
		[Token(Token = "0x6000493")]
		public static IntPtr ConvertToNative(CullingGroup cullingGroup) { }

	}

	[Token(Token = "0x20000B2")]
	internal sealed class StateChanged : MulticastDelegate
	{

		[Address(RVA = "0x1B5CF20", Offset = "0x1B5C320", Length = "0xA6")]
		[Token(Token = "0x6000491")]
		public StateChanged(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x6000492")]
		public override void Invoke(CullingGroupEvent sphere) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400020B")]
	internal IntPtr m_Ptr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400020C")]
	private StateChanged m_OnStateChanged; //Field offset: 0x18

	[Token(Token = "0x170000C4")]
	public Camera targetCamera
	{
		[Address(RVA = "0x2FDDC20", Offset = "0x2FDD020", Length = "0xAE")]
		[Token(Token = "0x600047E")]
		 set { } //Length: 174
	}

	[Address(RVA = "0x2FDDB70", Offset = "0x2FDCF70", Length = "0x54")]
	[Token(Token = "0x600047A")]
	public CullingGroup() { }

	[Address(RVA = "0x2FDD290", Offset = "0x2FDC690", Length = "0x5F")]
	[Token(Token = "0x600047D")]
	public override void Dispose() { }

	[Address(RVA = "0x2FDD230", Offset = "0x2FDC630", Length = "0x51")]
	[FreeFunction("CullingGroup_Bindings::Dispose", HasExplicitThis = True)]
	[Token(Token = "0x600047C")]
	private void DisposeInternal() { }

	[Address(RVA = "0x2FDD1F0", Offset = "0x2FDC5F0", Length = "0x33")]
	[Token(Token = "0x6000489")]
	private static void DisposeInternal_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FDD2F0", Offset = "0x2FDC6F0", Length = "0x80")]
	[Token(Token = "0x600047B")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x2FDD3C0", Offset = "0x2FDC7C0", Length = "0x51")]
	[FreeFunction("CullingGroup_Bindings::FinalizerFailure", HasExplicitThis = True, IsThreadSafe = True)]
	[Token(Token = "0x6000488")]
	private void FinalizerFailure() { }

	[Address(RVA = "0x2FDD380", Offset = "0x2FDC780", Length = "0x33")]
	[Token(Token = "0x6000490")]
	private static void FinalizerFailure_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FDD420", Offset = "0x2FDC820", Length = "0x33")]
	[FreeFunction("CullingGroup_Bindings::Init")]
	[Token(Token = "0x6000487")]
	private static IntPtr Init(object scripting) { }

	[Address(RVA = "0x2FDD610", Offset = "0x2FDCA10", Length = "0x12E")]
	[Token(Token = "0x6000481")]
	public int QueryIndices(bool visible, Int32[] result, int firstIndex) { }

	[Address(RVA = "0x2FDD4D0", Offset = "0x2FDC8D0", Length = "0x137")]
	[FreeFunction("CullingGroup_Bindings::QueryIndices", HasExplicitThis = True)]
	[NativeThrows]
	[Token(Token = "0x6000482")]
	private int QueryIndices(bool visible, int distanceIndex, CullingQueryOptions options, Int32[] result, int firstIndex) { }

	[Address(RVA = "0x2FDD460", Offset = "0x2FDC860", Length = "0x63")]
	[Token(Token = "0x600048D")]
	private static int QueryIndices_Injected(IntPtr _unity_self, bool visible, int distanceIndex, CullingQueryOptions options, ref ManagedSpanWrapper result, int firstIndex) { }

	[Address(RVA = "0x2FDD740", Offset = "0x2FDCB40", Length = "0x6F")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000486")]
	private static void SendEvents(CullingGroup cullingGroup, IntPtr eventsPtr, int count) { }

	[Address(RVA = "0x2FDDC20", Offset = "0x2FDD020", Length = "0xAE")]
	[Token(Token = "0x600047E")]
	public void set_targetCamera(Camera value) { }

	[Address(RVA = "0x2FDDBD0", Offset = "0x2FDCFD0", Length = "0x42")]
	[Token(Token = "0x600048A")]
	private static void set_targetCamera_Injected(IntPtr _unity_self, IntPtr value) { }

	[Address(RVA = "0x2FDD800", Offset = "0x2FDCC00", Length = "0xF8")]
	[FreeFunction("CullingGroup_Bindings::SetBoundingDistances", HasExplicitThis = True)]
	[Token(Token = "0x6000483")]
	public void SetBoundingDistances(Single[] distances) { }

	[Address(RVA = "0x2FDD7B0", Offset = "0x2FDCBB0", Length = "0x42")]
	[Token(Token = "0x600048E")]
	private static void SetBoundingDistances_Injected(IntPtr _unity_self, ref ManagedSpanWrapper distances) { }

	[Address(RVA = "0x2FDD940", Offset = "0x2FDCD40", Length = "0x58")]
	[Token(Token = "0x6000480")]
	public void SetBoundingSphereCount(int count) { }

	[Address(RVA = "0x2FDD900", Offset = "0x2FDCD00", Length = "0x40")]
	[Token(Token = "0x600048C")]
	private static void SetBoundingSphereCount_Injected(IntPtr _unity_self, int count) { }

	[Address(RVA = "0x2FDD9F0", Offset = "0x2FDCDF0", Length = "0x5A")]
	[Token(Token = "0x600047F")]
	public void SetBoundingSpheres(BoundingSphere[] array) { }

	[Address(RVA = "0x2FDD9A0", Offset = "0x2FDCDA0", Length = "0x42")]
	[Token(Token = "0x600048B")]
	private static void SetBoundingSpheres_Injected(IntPtr _unity_self, BoundingSphere[] array) { }

	[Address(RVA = "0x2FDDB00", Offset = "0x2FDCF00", Length = "0x67")]
	[Token(Token = "0x6000485")]
	public void SetDistanceReferencePoint(Vector3 point) { }

	[Address(RVA = "0x2FDDAA0", Offset = "0x2FDCEA0", Length = "0x5A")]
	[FreeFunction("CullingGroup_Bindings::SetDistanceReferencePoint", HasExplicitThis = True)]
	[Token(Token = "0x6000484")]
	private void SetDistanceReferencePoint_InternalVector3(Vector3 point) { }

	[Address(RVA = "0x2FDDA50", Offset = "0x2FDCE50", Length = "0x42")]
	[Token(Token = "0x600048F")]
	private static void SetDistanceReferencePoint_InternalVector3_Injected(IntPtr _unity_self, in Vector3 point) { }

}

