namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20001AB")]
internal abstract class InitializeLocalInstruction : LocalAccessInstruction
{
	[Token(Token = "0x20001AE")]
	public sealed class ImmutableBox : InitializeLocalInstruction
	{
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000373")]
		private readonly object _defaultValue; //Field offset: 0x18

		[Token(Token = "0x170001EB")]
		public virtual string InstructionName
		{
			[Address(RVA = "0x229A1E0", Offset = "0x22995E0", Length = "0x2C")]
			[Token(Token = "0x6000965")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x229A1A0", Offset = "0x22995A0", Length = "0x40")]
		[Token(Token = "0x6000963")]
		internal ImmutableBox(int index, object defaultValue) { }

		[Address(RVA = "0x229A1E0", Offset = "0x22995E0", Length = "0x2C")]
		[Token(Token = "0x6000965")]
		public virtual string get_InstructionName() { }

		[Address(RVA = "0x229A0B0", Offset = "0x22994B0", Length = "0xE1")]
		[Token(Token = "0x6000964")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001AF")]
	public sealed class ImmutableRefBox : InitializeLocalInstruction
	{

		[Token(Token = "0x170001EC")]
		public virtual string InstructionName
		{
			[Address(RVA = "0x229A2F0", Offset = "0x22996F0", Length = "0x2C")]
			[Token(Token = "0x6000968")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x609F60", Offset = "0x609360", Length = "0x24")]
		[Token(Token = "0x6000966")]
		internal ImmutableRefBox(int index) { }

		[Address(RVA = "0x229A2F0", Offset = "0x22996F0", Length = "0x2C")]
		[Token(Token = "0x6000968")]
		public virtual string get_InstructionName() { }

		[Address(RVA = "0x229A210", Offset = "0x2299610", Length = "0xD0")]
		[Token(Token = "0x6000967")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001AD")]
	public sealed class ImmutableValue : InitializeLocalInstruction, IBoxableInstruction
	{
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000372")]
		private readonly object _defaultValue; //Field offset: 0x18

		[Token(Token = "0x170001EA")]
		public virtual string InstructionName
		{
			[Address(RVA = "0x229A440", Offset = "0x2299840", Length = "0x2C")]
			[Token(Token = "0x6000962")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x229A1A0", Offset = "0x22995A0", Length = "0x40")]
		[Token(Token = "0x600095F")]
		internal ImmutableValue(int index, object defaultValue) { }

		[Address(RVA = "0x229A320", Offset = "0x2299720", Length = "0x85")]
		[Token(Token = "0x6000961")]
		public override Instruction BoxIfIndexMatches(int index) { }

		[Address(RVA = "0x229A440", Offset = "0x2299840", Length = "0x2C")]
		[Token(Token = "0x6000962")]
		public virtual string get_InstructionName() { }

		[Address(RVA = "0x229A3B0", Offset = "0x22997B0", Length = "0x88")]
		[Token(Token = "0x6000960")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001B3")]
	public sealed class MutableBox : InitializeLocalInstruction
	{
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000375")]
		private readonly Type _type; //Field offset: 0x18

		[Token(Token = "0x170001F0")]
		public virtual string InstructionName
		{
			[Address(RVA = "0x22A1CA0", Offset = "0x22A10A0", Length = "0x2C")]
			[Token(Token = "0x6000976")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x229A1A0", Offset = "0x22995A0", Length = "0x40")]
		[Token(Token = "0x6000974")]
		internal MutableBox(int index, Type type) { }

		[Address(RVA = "0x22A1CA0", Offset = "0x22A10A0", Length = "0x2C")]
		[Token(Token = "0x6000976")]
		public virtual string get_InstructionName() { }

		[Address(RVA = "0x22A1B60", Offset = "0x22A0F60", Length = "0x133")]
		[Token(Token = "0x6000975")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001B2")]
	public sealed class MutableValue : InitializeLocalInstruction, IBoxableInstruction
	{
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000374")]
		private readonly Type _type; //Field offset: 0x18

		[Token(Token = "0x170001EF")]
		public virtual string InstructionName
		{
			[Address(RVA = "0x22A1E40", Offset = "0x22A1240", Length = "0x2C")]
			[Token(Token = "0x6000973")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x229A1A0", Offset = "0x22995A0", Length = "0x40")]
		[Token(Token = "0x6000970")]
		internal MutableValue(int index, Type type) { }

		[Address(RVA = "0x22A1CD0", Offset = "0x22A10D0", Length = "0x85")]
		[Token(Token = "0x6000972")]
		public override Instruction BoxIfIndexMatches(int index) { }

		[Address(RVA = "0x22A1E40", Offset = "0x22A1240", Length = "0x2C")]
		[Token(Token = "0x6000973")]
		public virtual string get_InstructionName() { }

		[Address(RVA = "0x22A1D60", Offset = "0x22A1160", Length = "0xDD")]
		[Token(Token = "0x6000971")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001B1")]
	public sealed class Parameter : InitializeLocalInstruction, IBoxableInstruction
	{

		[Token(Token = "0x170001EE")]
		public virtual string InstructionName
		{
			[Address(RVA = "0x22A7050", Offset = "0x22A6450", Length = "0x2C")]
			[Token(Token = "0x600096F")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x609F60", Offset = "0x609360", Length = "0x24")]
		[Token(Token = "0x600096C")]
		internal Parameter(int index) { }

		[Address(RVA = "0x22A6FE0", Offset = "0x22A63E0", Length = "0x65")]
		[Token(Token = "0x600096E")]
		public override Instruction BoxIfIndexMatches(int index) { }

		[Address(RVA = "0x22A7050", Offset = "0x22A6450", Length = "0x2C")]
		[Token(Token = "0x600096F")]
		public virtual string get_InstructionName() { }

		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x600096D")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001B0")]
	public sealed class ParameterBox : InitializeLocalInstruction
	{

		[Token(Token = "0x170001ED")]
		public virtual string InstructionName
		{
			[Address(RVA = "0x22A6DB0", Offset = "0x22A61B0", Length = "0x2C")]
			[Token(Token = "0x600096B")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x609F60", Offset = "0x609360", Length = "0x24")]
		[Token(Token = "0x6000969")]
		public ParameterBox(int index) { }

		[Address(RVA = "0x22A6DB0", Offset = "0x22A61B0", Length = "0x2C")]
		[Token(Token = "0x600096B")]
		public virtual string get_InstructionName() { }

		[Address(RVA = "0x22A6CB0", Offset = "0x22A60B0", Length = "0xF7")]
		[Token(Token = "0x600096A")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001AC")]
	public sealed class Reference : InitializeLocalInstruction, IBoxableInstruction
	{

		[Token(Token = "0x170001E9")]
		public virtual string InstructionName
		{
			[Address(RVA = "0x22A7D00", Offset = "0x22A7100", Length = "0x2C")]
			[Token(Token = "0x600095E")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x609F60", Offset = "0x609360", Length = "0x24")]
		[Token(Token = "0x600095B")]
		internal Reference(int index) { }

		[Address(RVA = "0x22A7C40", Offset = "0x22A7040", Length = "0x65")]
		[Token(Token = "0x600095D")]
		public override Instruction BoxIfIndexMatches(int index) { }

		[Address(RVA = "0x22A7D00", Offset = "0x22A7100", Length = "0x2C")]
		[Token(Token = "0x600095E")]
		public virtual string get_InstructionName() { }

		[Address(RVA = "0x22A7CB0", Offset = "0x22A70B0", Length = "0x48")]
		[Token(Token = "0x600095C")]
		public virtual int Run(InterpretedFrame frame) { }

	}


	[Address(RVA = "0x609F60", Offset = "0x609360", Length = "0x24")]
	[Token(Token = "0x600095A")]
	internal InitializeLocalInstruction(int index) { }

}

