namespace Unity.Profiling.LowLevel.Unsafe;

[IsReadOnly]
[Token(Token = "0x2000035")]
[UsedByNativeCode]
public struct ProfilerRecorderHandle
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000091")]
	internal readonly ulong handle; //Field offset: 0x0

	[Token(Token = "0x17000014")]
	public bool Valid
	{
		[Address(RVA = "0x2FE41A0", Offset = "0x2FE35A0", Length = "0x11")]
		[Token(Token = "0x6000097")]
		 get { } //Length: 17
	}

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x6000096")]
	internal ProfilerRecorderHandle(ulong handle) { }

	[Address(RVA = "0x2FE41A0", Offset = "0x2FE35A0", Length = "0x11")]
	[Token(Token = "0x6000097")]
	public bool get_Valid() { }

	[Address(RVA = "0x2FE3FC0", Offset = "0x2FE33C0", Length = "0x5F")]
	[NativeMethod(IsThreadSafe = True)]
	[Token(Token = "0x6000099")]
	internal static ProfilerRecorderHandle GetByName__Unmanaged(ProfilerCategory category, Byte* name, int nameLen) { }

	[Address(RVA = "0x2FE3F50", Offset = "0x2FE3350", Length = "0x62")]
	[Token(Token = "0x600009B")]
	private static void GetByName__Unmanaged_Injected(in ProfilerCategory category, Byte* name, int nameLen, out ProfilerRecorderHandle ret) { }

	[Address(RVA = "0x2FE40C0", Offset = "0x2FE34C0", Length = "0xDA")]
	[Token(Token = "0x6000098")]
	public static ProfilerRecorderDescription GetDescription(ProfilerRecorderHandle handle) { }

	[Address(RVA = "0x2FE4070", Offset = "0x2FE3470", Length = "0x4B")]
	[NativeMethod(IsThreadSafe = True)]
	[Token(Token = "0x600009A")]
	private static ProfilerRecorderDescription GetDescriptionInternal(ProfilerRecorderHandle handle) { }

	[Address(RVA = "0x2FE4020", Offset = "0x2FE3420", Length = "0x42")]
	[Token(Token = "0x600009C")]
	private static void GetDescriptionInternal_Injected(in ProfilerRecorderHandle handle, out ProfilerRecorderDescription ret) { }

}

