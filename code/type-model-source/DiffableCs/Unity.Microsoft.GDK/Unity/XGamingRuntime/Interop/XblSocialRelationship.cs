namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000334")]
internal struct XblSocialRelationship
{
	[CompilerGenerated]
	[Token(Token = "0x2000335")]
	private sealed class <>c
	{
		[Token(Token = "0x4000925")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000926")]
		public static Func<UTF8StringPtr, String> <>9__0_0; //Field offset: 0x8

		[Address(RVA = "0x2B9F650", Offset = "0x2B9EA50", Length = "0x67")]
		[Token(Token = "0x60011A1")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60011A2")]
		public <>c() { }

		[Address(RVA = "0x2B9F320", Offset = "0x2B9E720", Length = "0x1A")]
		[Token(Token = "0x60011A3")]
		internal string <GetSocialNetworks>b__0_0(UTF8StringPtr s) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000920")]
	internal readonly ulong xboxUserId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000921")]
	internal readonly bool isFavorite; //Field offset: 0x8
	[FieldOffset(Offset = "0x9")]
	[Token(Token = "0x4000922")]
	internal readonly bool isFollowingCaller; //Field offset: 0x9
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000923")]
	internal readonly IntPtr socialNetworks; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000924")]
	internal readonly SizeT socialNetworksCount; //Field offset: 0x18

	[Address(RVA = "0x2BB8960", Offset = "0x2BB7D60", Length = "0x122")]
	[Token(Token = "0x60011A0")]
	internal String[] GetSocialNetworks() { }

}

