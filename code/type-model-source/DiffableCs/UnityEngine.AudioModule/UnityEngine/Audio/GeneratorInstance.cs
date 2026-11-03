namespace UnityEngine.Audio;

[Token(Token = "0x2000015")]
public struct GeneratorInstance : IEquatable<GeneratorInstance>
{
	[Token(Token = "0x2000019")]
	internal struct Configuration
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000033")]
		internal Setup Setup; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000034")]
		internal Properties Properties; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000035")]
		internal DiscreteTime ReportedLength; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000036")]
		internal bool IsFinite; //Field offset: 0x18
		[FieldOffset(Offset = "0x19")]
		[Token(Token = "0x4000037")]
		internal bool IsRealtime; //Field offset: 0x19
		[FieldOffset(Offset = "0x1A")]
		[Token(Token = "0x4000038")]
		internal bool HasKnownLength; //Field offset: 0x1A

		[Token(Token = "0x1700001F")]
		public bool isRealtime
		{
			[Address(RVA = "0x1D88C10", Offset = "0x1D88010", Length = "0x5")]
			[Token(Token = "0x6000094")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000020")]
		public Nullable<DiscreteTime> length
		{
			[Address(RVA = "0x2FCA3D0", Offset = "0x2FC97D0", Length = "0x68")]
			[Token(Token = "0x6000095")]
			 get { } //Length: 104
		}

		[Address(RVA = "0x1D88C10", Offset = "0x1D88010", Length = "0x5")]
		[Token(Token = "0x6000094")]
		public bool get_isRealtime() { }

		[Address(RVA = "0x2FCA3D0", Offset = "0x2FC97D0", Length = "0x68")]
		[Token(Token = "0x6000095")]
		public Nullable<DiscreteTime> get_length() { }

	}

	[NativeHeader("Modules/Audio/Public/ScriptableProcessors/ScriptBindings/GeneratorHandle.h")]
	[RequiredByNativeCode]
	[Token(Token = "0x200001A")]
	public struct GeneratorHeader
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000039")]
		internal ProcessorHeader Processor; //Field offset: 0x0
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400003A")]
		internal Configuration Configuration; //Field offset: 0x38

	}

	[Token(Token = "0x2000016")]
	internal interface ICapabilities
	{

		[Token(Token = "0x1700001C")]
		public bool isFinite
		{
			[Token(Token = "0x6000091")]
			 get { } //Length: 0
		}

		[Token(Token = "0x1700001D")]
		public bool isRealtime
		{
			[Token(Token = "0x6000092")]
			 get { } //Length: 0
		}

		[Token(Token = "0x1700001E")]
		public Nullable<DiscreteTime> length
		{
			[Token(Token = "0x6000093")]
			 get { } //Length: 0
		}

		[Token(Token = "0x6000091")]
		public bool get_isFinite() { }

		[Token(Token = "0x6000092")]
		public bool get_isRealtime() { }

		[Token(Token = "0x6000093")]
		public Nullable<DiscreteTime> get_length() { }

	}

	[Token(Token = "0x2000018")]
	internal struct Properties
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000032")]
		private byte m_Reserved; //Field offset: 0x0

	}

	[IsReadOnly]
	[Token(Token = "0x2000017")]
	internal struct Setup
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000030")]
		public readonly AudioSpeakerMode speakerMode; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000031")]
		public readonly int sampleRate; //Field offset: 0x4

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400002F")]
	internal readonly ProcessorInstance m_ProcessorInstance; //Field offset: 0x0

	[Address(RVA = "0x2FCA5A0", Offset = "0x2FC99A0", Length = "0x33")]
	[Token(Token = "0x600008E")]
	public override bool Equals(GeneratorInstance other) { }

	[Address(RVA = "0x2FCA5E0", Offset = "0x2FC99E0", Length = "0xAB")]
	[Token(Token = "0x600008F")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2FCA690", Offset = "0x2FC9A90", Length = "0x22")]
	[Token(Token = "0x6000090")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0xAEF030", Offset = "0xAEE430", Length = "0x14")]
	[Token(Token = "0x600008D")]
	public static ProcessorInstance op_Implicit(in GeneratorInstance generatorInstance) { }

}

