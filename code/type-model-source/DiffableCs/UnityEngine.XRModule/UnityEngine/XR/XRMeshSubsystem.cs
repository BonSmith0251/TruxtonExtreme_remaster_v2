namespace UnityEngine.XR;

[NativeConditional("ENABLE_XR")]
[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshingSubsystem.h")]
[NativeHeader("Modules/XR/XRPrefix.h")]
[Token(Token = "0x2000020")]
[UsedByNativeCode]
public class XRMeshSubsystem : IntegratedSubsystem<XRMeshSubsystemDescriptor>
{
	[IsReadOnly]
	[NativeConditional("ENABLE_XR")]
	[Token(Token = "0x2000021")]
	private struct MeshTransformList : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400009A")]
		private readonly IntPtr m_Self; //Field offset: 0x0

		[Address(RVA = "0x34925E0", Offset = "0x34919E0", Length = "0x33")]
		[Token(Token = "0x6000071")]
		public override void Dispose() { }

		[Address(RVA = "0x3492620", Offset = "0x3491A20", Length = "0x33")]
		[FreeFunction("UnityXRMeshTransformList_Dispose")]
		[Token(Token = "0x6000072")]
		private static void Dispose(IntPtr self) { }

	}


	[Address(RVA = "0x3493F20", Offset = "0x3493320", Length = "0x39")]
	[Token(Token = "0x6000070")]
	public XRMeshSubsystem() { }

	[Address(RVA = "0x3493EB0", Offset = "0x34932B0", Length = "0x61")]
	[RequiredByNativeCode]
	[Token(Token = "0x600006F")]
	private void InvokeMeshReadyDelegate(MeshGenerationResult result, Action<MeshGenerationResult> onMeshGenerationComplete) { }

}

