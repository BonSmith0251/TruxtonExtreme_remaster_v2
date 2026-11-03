namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000345")]
internal struct XblTitleManagedStatistic
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400096E")]
	internal readonly UTF8StringPtr statisticName; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400096F")]
	internal readonly XblTitleManagedStatType statisticType; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000970")]
	internal readonly double numberValue; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000971")]
	internal readonly UTF8StringPtr stringValue; //Field offset: 0x18

	[Address(RVA = "0x2BB8CC0", Offset = "0x2BB80C0", Length = "0x88")]
	[Token(Token = "0x60011B2")]
	internal XblTitleManagedStatistic(XblTitleManagedStatistic publicObject, DisposableCollection disposableCollection) { }

}

