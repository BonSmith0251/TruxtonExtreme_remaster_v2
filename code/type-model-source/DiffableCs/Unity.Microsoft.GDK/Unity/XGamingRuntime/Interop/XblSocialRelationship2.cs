namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000336")]
internal struct XblSocialRelationship2
{
	[CompilerGenerated]
	[Token(Token = "0x2000337")]
	private sealed class <>c
	{
		[Token(Token = "0x400092D")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400092E")]
		public static Func<UTF8StringPtr, String> <>9__0_0; //Field offset: 0x8

		[Address(RVA = "0x2B9F5E0", Offset = "0x2B9E9E0", Length = "0x67")]
		[Token(Token = "0x60011A5")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60011A6")]
		public <>c() { }

		[Address(RVA = "0x2B9F320", Offset = "0x2B9E720", Length = "0x1A")]
		[Token(Token = "0x60011A7")]
		internal string <GetSocialNetworks>b__0_0(UTF8StringPtr s) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000927")]
	internal readonly ulong xboxUserId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000928")]
	internal readonly bool isFavorite; //Field offset: 0x8
	[FieldOffset(Offset = "0x9")]
	[Token(Token = "0x4000929")]
	internal readonly bool isFriend; //Field offset: 0x9
	[FieldOffset(Offset = "0xA")]
	[Token(Token = "0x400092A")]
	internal readonly bool isFollowingCaller; //Field offset: 0xA
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400092B")]
	internal readonly IntPtr socialNetworks; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400092C")]
	internal readonly SizeT socialNetworksCount; //Field offset: 0x18

	[Address(RVA = "0x2BB8830", Offset = "0x2BB7C30", Length = "0x122")]
	[Token(Token = "0x60011A4")]
	internal String[] GetSocialNetworks() { }

}

