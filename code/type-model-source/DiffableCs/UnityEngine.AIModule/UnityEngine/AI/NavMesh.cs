namespace UnityEngine.AI;

[MovedFrom("UnityEngine")]
[NativeHeader("Modules/AI/NavMesh/NavMesh.bindings.h")]
[NativeHeader("Modules/AI/NavMeshManager.h")]
[StaticAccessor("NavMeshBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x2000002")]
public static class NavMesh
{
	[Token(Token = "0x2000003")]
	internal sealed class OnNavMeshPreUpdate : MulticastDelegate
	{

		[Address(RVA = "0x639280", Offset = "0x638680", Length = "0xA5")]
		[Token(Token = "0x6000003")]
		public OnNavMeshPreUpdate(object object, IntPtr method) { }

		[Address(RVA = "0x639270", Offset = "0x638670", Length = "0xF")]
		[Token(Token = "0x6000004")]
		public override void Invoke() { }

	}

	[Token(Token = "0x4000001")]
	public static OnNavMeshPreUpdate onPreUpdate; //Field offset: 0x0

	[Address(RVA = "0x2F9BAD0", Offset = "0x2F9AED0", Length = "0x4E")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	[Token(Token = "0x6000001")]
	private static void ClearPreUpdateListeners() { }

	[Address(RVA = "0x2F9BB20", Offset = "0x2F9AF20", Length = "0x1D8")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000002")]
	private static void Internal_CallOnNavMeshPreUpdate() { }

}

