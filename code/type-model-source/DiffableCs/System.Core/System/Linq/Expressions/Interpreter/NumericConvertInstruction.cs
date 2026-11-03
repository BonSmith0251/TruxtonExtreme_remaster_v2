namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000202")]
internal abstract class NumericConvertInstruction : Instruction
{
	[Token(Token = "0x2000204")]
	public sealed class Checked : NumericConvertInstruction
	{

		[Token(Token = "0x1700021A")]
		public virtual string InstructionName
		{
			[Address(RVA = "0x2293DE0", Offset = "0x22931E0", Length = "0x2C")]
			[Token(Token = "0x6000A4E")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x2293D90", Offset = "0x2293190", Length = "0x46")]
		[Token(Token = "0x6000A4F")]
		public Checked(TypeCode from, TypeCode to, bool isLiftedToNull) { }

		[Address(RVA = "0x22939F0", Offset = "0x2292DF0", Length = "0x28")]
		[Token(Token = "0x6000A50")]
		protected virtual object Convert(object obj) { }

		[Address(RVA = "0x2292D80", Offset = "0x2292180", Length = "0x350")]
		[Token(Token = "0x6000A54")]
		private object ConvertDouble(double obj) { }

		[Address(RVA = "0x2293100", Offset = "0x2292500", Length = "0x278")]
		[Token(Token = "0x6000A51")]
		private object ConvertInt32(int obj) { }

		[Address(RVA = "0x22933B0", Offset = "0x22927B0", Length = "0x2B4")]
		[Token(Token = "0x6000A52")]
		private object ConvertInt64(long obj) { }

		[Address(RVA = "0x22936A0", Offset = "0x2292AA0", Length = "0x31C")]
		[Token(Token = "0x6000A53")]
		private object ConvertUInt64(ulong obj) { }

		[Address(RVA = "0x2293DE0", Offset = "0x22931E0", Length = "0x2C")]
		[Token(Token = "0x6000A4E")]
		public virtual string get_InstructionName() { }

	}

	[Token(Token = "0x2000205")]
	public sealed class ToUnderlying : NumericConvertInstruction
	{

		[Token(Token = "0x1700021B")]
		public virtual string InstructionName
		{
			[Address(RVA = "0x22ABF60", Offset = "0x22AB360", Length = "0x2C")]
			[Token(Token = "0x6000A55")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x22ABF20", Offset = "0x22AB320", Length = "0x39")]
		[Token(Token = "0x6000A56")]
		public ToUnderlying(TypeCode to, bool isLiftedToNull) { }

		[Address(RVA = "0x22ABB60", Offset = "0x22AAF60", Length = "0x390")]
		[Token(Token = "0x6000A57")]
		protected virtual object Convert(object obj) { }

		[Address(RVA = "0x22ABF60", Offset = "0x22AB360", Length = "0x2C")]
		[Token(Token = "0x6000A55")]
		public virtual string get_InstructionName() { }

	}

	[Token(Token = "0x2000203")]
	public sealed class Unchecked : NumericConvertInstruction
	{

		[Token(Token = "0x17000219")]
		public virtual string InstructionName
		{
			[Address(RVA = "0x22AD590", Offset = "0x22AC990", Length = "0x2C")]
			[Token(Token = "0x6000A47")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x2293D90", Offset = "0x2293190", Length = "0x46")]
		[Token(Token = "0x6000A48")]
		public Unchecked(TypeCode from, TypeCode to, bool isLiftedToNull) { }

		[Address(RVA = "0x22AD000", Offset = "0x22AC400", Length = "0x38")]
		[Token(Token = "0x6000A49")]
		protected virtual object Convert(object obj) { }

		[Address(RVA = "0x22AC7C0", Offset = "0x22ABBC0", Length = "0x238")]
		[Token(Token = "0x6000A4D")]
		private object ConvertDouble(double obj) { }

		[Address(RVA = "0x22ACA30", Offset = "0x22ABE30", Length = "0x1B4")]
		[Token(Token = "0x6000A4A")]
		private object ConvertInt32(int obj) { }

		[Address(RVA = "0x22ACC20", Offset = "0x22AC020", Length = "0x1A0")]
		[Token(Token = "0x6000A4B")]
		private object ConvertInt64(long obj) { }

		[Address(RVA = "0x22ACDF0", Offset = "0x22AC1F0", Length = "0x1DC")]
		[Token(Token = "0x6000A4C")]
		private object ConvertUInt64(ulong obj) { }

		[Address(RVA = "0x22AD590", Offset = "0x22AC990", Length = "0x2C")]
		[Token(Token = "0x6000A47")]
		public virtual string get_InstructionName() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003C7")]
	internal readonly TypeCode _from; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40003C8")]
	internal readonly TypeCode _to; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003C9")]
	private readonly bool _isLiftedToNull; //Field offset: 0x18

	[Token(Token = "0x17000217")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000A44")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000216")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x22A5F30", Offset = "0x22A5330", Length = "0x2C")]
		[Token(Token = "0x6000A43")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000218")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000A45")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2293D90", Offset = "0x2293190", Length = "0x46")]
	[Token(Token = "0x6000A40")]
	protected NumericConvertInstruction(TypeCode from, TypeCode to, bool isLiftedToNull) { }

	[Token(Token = "0x6000A42")]
	protected abstract object Convert(object obj) { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000A44")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x22A5F30", Offset = "0x22A5330", Length = "0x2C")]
	[Token(Token = "0x6000A43")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000A45")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x22A5C90", Offset = "0x22A5090", Length = "0xF4")]
	[Token(Token = "0x6000A41")]
	public virtual int Run(InterpretedFrame frame) { }

	[Address(RVA = "0x22A5D90", Offset = "0x22A5190", Length = "0x19D")]
	[Token(Token = "0x6000A46")]
	public virtual string ToString() { }

}

