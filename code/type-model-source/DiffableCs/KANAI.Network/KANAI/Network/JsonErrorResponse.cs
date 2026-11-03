namespace KANAI.Network;

[Token(Token = "0x2000013")]
public class JsonErrorResponse
{
	[Token(Token = "0x2000014")]
	internal class Data
	{
		[Token(Token = "0x2000015")]
		internal class Option
		{
			[Token(Token = "0x2000016")]
			internal class Dialog
			{
				[FieldOffset(Offset = "0x10")]
				[Token(Token = "0x4000062")]
				public string title; //Field offset: 0x10
				[FieldOffset(Offset = "0x18")]
				[Token(Token = "0x4000063")]
				public string message; //Field offset: 0x18
				[FieldOffset(Offset = "0x20")]
				[Token(Token = "0x4000064")]
				public string maintenanceTime; //Field offset: 0x20
				[FieldOffset(Offset = "0x28")]
				[Token(Token = "0x4000065")]
				public bool isExit; //Field offset: 0x28
				[FieldOffset(Offset = "0x29")]
				[Token(Token = "0x4000066")]
				public bool isOverrideError; //Field offset: 0x29
				[FieldOffset(Offset = "0x2C")]
				[Token(Token = "0x4000067")]
				public int retryCount; //Field offset: 0x2C

				[Address(RVA = "0x1DFF710", Offset = "0x1DFEB10", Length = "0x72")]
				[Token(Token = "0x6000079")]
				public Dialog() { }

			}

			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000061")]
			public Dialog dialog; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000078")]
			public Option() { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000060")]
		public Option option; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000077")]
		public Data() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400005D")]
	public Data data; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400005E")]
	public int code; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400005F")]
	public string message; //Field offset: 0x20

	[Address(RVA = "0x1E027B0", Offset = "0x1E01BB0", Length = "0x36")]
	[Token(Token = "0x6000076")]
	public JsonErrorResponse() { }

	[Address(RVA = "0x1E02790", Offset = "0x1E01B90", Length = "0x1E")]
	[Token(Token = "0x6000075")]
	public Dialog Get() { }

}

