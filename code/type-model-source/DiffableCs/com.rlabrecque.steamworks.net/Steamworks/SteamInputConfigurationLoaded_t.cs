namespace Steamworks;

[CallbackIdentity(2803)]
[Token(Token = "0x2000071")]
public struct SteamInputConfigurationLoaded_t
{
	[Token(Token = "0x4000118")]
	public const int k_iCallback = 2803; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000119")]
	public AppId_t m_unAppID; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400011A")]
	public InputHandle_t m_ulDeviceHandle; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400011B")]
	public CSteamID m_ulMappingCreator; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400011C")]
	public uint m_unMajorRevision; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400011D")]
	public uint m_unMinorRevision; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400011E")]
	public bool m_bUsesSteamInputAPI; //Field offset: 0x20
	[FieldOffset(Offset = "0x21")]
	[Token(Token = "0x400011F")]
	public bool m_bUsesGamepadAPI; //Field offset: 0x21

}

