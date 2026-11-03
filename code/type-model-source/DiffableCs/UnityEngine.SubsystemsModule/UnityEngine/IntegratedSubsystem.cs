namespace UnityEngine;

[NativeHeader("Modules/Subsystems/Subsystem.h")]
[Token(Token = "0x2000002")]
[UsedByNativeCode]
public class IntegratedSubsystem : ISubsystem
{
	[Token(Token = "0x2000003")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
		[Token(Token = "0x6000008")]
		public static IntPtr ConvertToNative(IntegratedSubsystem integratedSubsystem) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000001")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.XRModule"})]
	internal IntPtr m_Ptr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000002")]
	internal ISubsystemDescriptor m_SubsystemDescriptor; //Field offset: 0x18

	[Token(Token = "0x17000001")]
	public override bool running
	{
		[Address(RVA = "0x31666B0", Offset = "0x3165AB0", Length = "0x56")]
		[Token(Token = "0x6000002")]
		 get { } //Length: 86
	}

	[Token(Token = "0x17000002")]
	internal bool valid
	{
		[Address(RVA = "0x30D67D0", Offset = "0x30D5BD0", Length = "0x9")]
		[Token(Token = "0x6000003")]
		internal get { } //Length: 9
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000005")]
	public IntegratedSubsystem() { }

	[Address(RVA = "0x31666B0", Offset = "0x3165AB0", Length = "0x56")]
	[Token(Token = "0x6000002")]
	public override bool get_running() { }

	[Address(RVA = "0x30D67D0", Offset = "0x30D5BD0", Length = "0x9")]
	[Token(Token = "0x6000003")]
	internal bool get_valid() { }

	[Address(RVA = "0x31665A0", Offset = "0x31659A0", Length = "0x51")]
	[Token(Token = "0x6000004")]
	internal bool IsRunning() { }

	[Address(RVA = "0x3166560", Offset = "0x3165960", Length = "0x33")]
	[Token(Token = "0x6000007")]
	private static bool IsRunning_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3166650", Offset = "0x3165A50", Length = "0x5A")]
	[Token(Token = "0x6000001")]
	internal void SetHandle(IntegratedSubsystem subsystem) { }

	[Address(RVA = "0x3166600", Offset = "0x3165A00", Length = "0x42")]
	[Token(Token = "0x6000006")]
	private static void SetHandle_Injected(IntPtr _unity_self, IntegratedSubsystem subsystem) { }

}

