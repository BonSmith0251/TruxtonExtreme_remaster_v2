namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20001DE")]
internal abstract class NotEqualInstruction : Instruction
{
	[Token(Token = "0x20001DF")]
	private sealed class NotEqualBoolean : NotEqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60009F4")]
		public NotEqualBoolean() { }

		[Address(RVA = "0x22A2F90", Offset = "0x22A2390", Length = "0xBB")]
		[Token(Token = "0x60009F3")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001E5")]
	private sealed class NotEqualByte : NotEqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000A00")]
		public NotEqualByte() { }

		[Address(RVA = "0x22A3120", Offset = "0x22A2520", Length = "0xBB")]
		[Token(Token = "0x60009FF")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001F1")]
	private sealed class NotEqualByteLiftedToNull : NotEqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000A18")]
		public NotEqualByteLiftedToNull() { }

		[Address(RVA = "0x22A3050", Offset = "0x22A2450", Length = "0xC1")]
		[Token(Token = "0x6000A17")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001E2")]
	private sealed class NotEqualChar : NotEqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60009FA")]
		public NotEqualChar() { }

		[Address(RVA = "0x22A32B0", Offset = "0x22A26B0", Length = "0xBB")]
		[Token(Token = "0x60009F9")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001EE")]
	private sealed class NotEqualCharLiftedToNull : NotEqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000A12")]
		public NotEqualCharLiftedToNull() { }

		[Address(RVA = "0x22A31E0", Offset = "0x22A25E0", Length = "0xC1")]
		[Token(Token = "0x6000A11")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001EA")]
	private sealed class NotEqualDouble : NotEqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000A0A")]
		public NotEqualDouble() { }

		[Address(RVA = "0x22A3450", Offset = "0x22A2850", Length = "0xC9")]
		[Token(Token = "0x6000A09")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001F6")]
	private sealed class NotEqualDoubleLiftedToNull : NotEqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000A22")]
		public NotEqualDoubleLiftedToNull() { }

		[Address(RVA = "0x22A3370", Offset = "0x22A2770", Length = "0xDB")]
		[Token(Token = "0x6000A21")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001E1")]
	private sealed class NotEqualInt16 : NotEqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60009F8")]
		public NotEqualInt16() { }

		[Address(RVA = "0x22A41C0", Offset = "0x22A35C0", Length = "0xBB")]
		[Token(Token = "0x60009F7")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001ED")]
	private sealed class NotEqualInt16LiftedToNull : NotEqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000A10")]
		public NotEqualInt16LiftedToNull() { }

		[Address(RVA = "0x22A40F0", Offset = "0x22A34F0", Length = "0xC1")]
		[Token(Token = "0x6000A0F")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001E3")]
	private sealed class NotEqualInt32 : NotEqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60009FC")]
		public NotEqualInt32() { }

		[Address(RVA = "0x22A4340", Offset = "0x22A3740", Length = "0xB9")]
		[Token(Token = "0x60009FB")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001EF")]
	private sealed class NotEqualInt32LiftedToNull : NotEqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000A14")]
		public NotEqualInt32LiftedToNull() { }

		[Address(RVA = "0x22A4280", Offset = "0x22A3680", Length = "0xBF")]
		[Token(Token = "0x6000A13")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001E4")]
	private sealed class NotEqualInt64 : NotEqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60009FE")]
		public NotEqualInt64() { }

		[Address(RVA = "0x22A44D0", Offset = "0x22A38D0", Length = "0xBB")]
		[Token(Token = "0x60009FD")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001F0")]
	private sealed class NotEqualInt64LiftedToNull : NotEqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000A16")]
		public NotEqualInt64LiftedToNull() { }

		[Address(RVA = "0x22A4400", Offset = "0x22A3800", Length = "0xC1")]
		[Token(Token = "0x6000A15")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001EB")]
	private sealed class NotEqualReference : NotEqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000A0C")]
		public NotEqualReference() { }

		[Address(RVA = "0x22A4590", Offset = "0x22A3990", Length = "0x50")]
		[Token(Token = "0x6000A0B")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001E0")]
	private sealed class NotEqualSByte : NotEqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60009F6")]
		public NotEqualSByte() { }

		[Address(RVA = "0x22A46C0", Offset = "0x22A3AC0", Length = "0xBB")]
		[Token(Token = "0x60009F5")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001EC")]
	private sealed class NotEqualSByteLiftedToNull : NotEqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000A0E")]
		public NotEqualSByteLiftedToNull() { }

		[Address(RVA = "0x22A45F0", Offset = "0x22A39F0", Length = "0xC1")]
		[Token(Token = "0x6000A0D")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001E9")]
	private sealed class NotEqualSingle : NotEqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000A08")]
		public NotEqualSingle() { }

		[Address(RVA = "0x22A4860", Offset = "0x22A3C60", Length = "0xC8")]
		[Token(Token = "0x6000A07")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001F5")]
	private sealed class NotEqualSingleLiftedToNull : NotEqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000A20")]
		public NotEqualSingleLiftedToNull() { }

		[Address(RVA = "0x22A4780", Offset = "0x22A3B80", Length = "0xDA")]
		[Token(Token = "0x6000A1F")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001E6")]
	private sealed class NotEqualUInt16 : NotEqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000A02")]
		public NotEqualUInt16() { }

		[Address(RVA = "0x22A4A00", Offset = "0x22A3E00", Length = "0xBB")]
		[Token(Token = "0x6000A01")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001F2")]
	private sealed class NotEqualUInt16LiftedToNull : NotEqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000A1A")]
		public NotEqualUInt16LiftedToNull() { }

		[Address(RVA = "0x22A4930", Offset = "0x22A3D30", Length = "0xC1")]
		[Token(Token = "0x6000A19")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001E7")]
	private sealed class NotEqualUInt32 : NotEqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000A04")]
		public NotEqualUInt32() { }

		[Address(RVA = "0x22A4B80", Offset = "0x22A3F80", Length = "0xB9")]
		[Token(Token = "0x6000A03")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001F3")]
	private sealed class NotEqualUInt32LiftedToNull : NotEqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000A1C")]
		public NotEqualUInt32LiftedToNull() { }

		[Address(RVA = "0x22A4AC0", Offset = "0x22A3EC0", Length = "0xBF")]
		[Token(Token = "0x6000A1B")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001E8")]
	private sealed class NotEqualUInt64 : NotEqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000A06")]
		public NotEqualUInt64() { }

		[Address(RVA = "0x22A4D10", Offset = "0x22A4110", Length = "0xBB")]
		[Token(Token = "0x6000A05")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001F4")]
	private sealed class NotEqualUInt64LiftedToNull : NotEqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000A1E")]
		public NotEqualUInt64LiftedToNull() { }

		[Address(RVA = "0x22A4C40", Offset = "0x22A4040", Length = "0xC1")]
		[Token(Token = "0x6000A1D")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x40003A5")]
	private static Instruction s_reference; //Field offset: 0x0
	[Token(Token = "0x40003A6")]
	private static Instruction s_Boolean; //Field offset: 0x8
	[Token(Token = "0x40003A7")]
	private static Instruction s_SByte; //Field offset: 0x10
	[Token(Token = "0x40003A8")]
	private static Instruction s_Int16; //Field offset: 0x18
	[Token(Token = "0x40003A9")]
	private static Instruction s_Char; //Field offset: 0x20
	[Token(Token = "0x40003AA")]
	private static Instruction s_Int32; //Field offset: 0x28
	[Token(Token = "0x40003AB")]
	private static Instruction s_Int64; //Field offset: 0x30
	[Token(Token = "0x40003AC")]
	private static Instruction s_Byte; //Field offset: 0x38
	[Token(Token = "0x40003AD")]
	private static Instruction s_UInt16; //Field offset: 0x40
	[Token(Token = "0x40003AE")]
	private static Instruction s_UInt32; //Field offset: 0x48
	[Token(Token = "0x40003AF")]
	private static Instruction s_UInt64; //Field offset: 0x50
	[Token(Token = "0x40003B0")]
	private static Instruction s_Single; //Field offset: 0x58
	[Token(Token = "0x40003B1")]
	private static Instruction s_Double; //Field offset: 0x60
	[Token(Token = "0x40003B2")]
	private static Instruction s_SByteLiftedToNull; //Field offset: 0x68
	[Token(Token = "0x40003B3")]
	private static Instruction s_Int16LiftedToNull; //Field offset: 0x70
	[Token(Token = "0x40003B4")]
	private static Instruction s_CharLiftedToNull; //Field offset: 0x78
	[Token(Token = "0x40003B5")]
	private static Instruction s_Int32LiftedToNull; //Field offset: 0x80
	[Token(Token = "0x40003B6")]
	private static Instruction s_Int64LiftedToNull; //Field offset: 0x88
	[Token(Token = "0x40003B7")]
	private static Instruction s_ByteLiftedToNull; //Field offset: 0x90
	[Token(Token = "0x40003B8")]
	private static Instruction s_UInt16LiftedToNull; //Field offset: 0x98
	[Token(Token = "0x40003B9")]
	private static Instruction s_UInt32LiftedToNull; //Field offset: 0xA0
	[Token(Token = "0x40003BA")]
	private static Instruction s_UInt64LiftedToNull; //Field offset: 0xA8
	[Token(Token = "0x40003BB")]
	private static Instruction s_SingleLiftedToNull; //Field offset: 0xB0
	[Token(Token = "0x40003BC")]
	private static Instruction s_DoubleLiftedToNull; //Field offset: 0xB8

	[Token(Token = "0x1700020D")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x60009EE")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700020F")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x22A40C0", Offset = "0x22A34C0", Length = "0x2C")]
		[Token(Token = "0x60009F0")]
		 get { } //Length: 44
	}

	[Token(Token = "0x1700020E")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x60009EF")]
		 get { } //Length: 6
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x60009F1")]
	private NotEqualInstruction() { }

	[Address(RVA = "0x22A3520", Offset = "0x22A2920", Length = "0x6D8")]
	[Token(Token = "0x60009F2")]
	public static Instruction Create(Type type, bool liftedToNull) { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x60009EE")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x22A40C0", Offset = "0x22A34C0", Length = "0x2C")]
	[Token(Token = "0x60009F0")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x60009EF")]
	public virtual int get_ProducedStack() { }

}

