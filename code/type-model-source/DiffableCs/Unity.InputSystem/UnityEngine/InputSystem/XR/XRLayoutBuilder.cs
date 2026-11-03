namespace UnityEngine.InputSystem.XR;

[Token(Token = "0x20000EB")]
internal class XRLayoutBuilder
{
	[CompilerGenerated]
	[Token(Token = "0x20000EC")]
	private sealed class <>c__DisplayClass5_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000594")]
		public XRLayoutBuilder layout; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000C6C")]
		public <>c__DisplayClass5_0() { }

		[Address(RVA = "0x29CE430", Offset = "0x29CD830", Length = "0x1D")]
		[Token(Token = "0x6000C6D")]
		internal InputControlLayout <OnFindLayoutForDevice>b__0() { }

	}

	[Token(Token = "0x4000592")]
	private static readonly String[] poseSubControlNames; //Field offset: 0x0
	[Token(Token = "0x4000593")]
	private static readonly FeatureType[] poseSubControlTypes; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400058F")]
	private string parentLayout; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000590")]
	private string interfaceName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000591")]
	private XRDeviceDescriptor descriptor; //Field offset: 0x20

	[Address(RVA = "0x29D34E0", Offset = "0x29D28E0", Length = "0x1E8")]
	[Token(Token = "0x6000C6B")]
	private static XRLayoutBuilder() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000C6A")]
	public XRLayoutBuilder() { }

	[Address(RVA = "0x29D1D90", Offset = "0x29D1190", Length = "0xD80")]
	[Token(Token = "0x6000C69")]
	private InputControlLayout Build() { }

	[Address(RVA = "0x29D2B40", Offset = "0x29D1F40", Length = "0x1BC")]
	[Token(Token = "0x6000C65")]
	private static string ConvertPotentialAliasToName(InputControlLayout layout, string nameOrAlias) { }

	[Address(RVA = "0x29D2D00", Offset = "0x29D2100", Length = "0x38")]
	[Token(Token = "0x6000C67")]
	private string GetParentControlName(string name) { }

	[Address(RVA = "0x29D2D40", Offset = "0x29D2140", Length = "0x24")]
	[Token(Token = "0x6000C62")]
	private static uint GetSizeOfFeature(XRFeatureDescriptor featureDescriptor) { }

	[Address(RVA = "0x29D2E00", Offset = "0x29D2200", Length = "0x164")]
	[Token(Token = "0x6000C68")]
	private bool IsPoseControl(List<XRFeatureDescriptor> features, int startIndex) { }

	[Address(RVA = "0x29D2F70", Offset = "0x29D2370", Length = "0x25")]
	[Token(Token = "0x6000C66")]
	private bool IsSubControl(string name) { }

	[Address(RVA = "0x29D2FA0", Offset = "0x29D23A0", Length = "0x3D2")]
	[Token(Token = "0x6000C64")]
	internal static string OnFindLayoutForDevice(ref InputDeviceDescription description, string matchedLayout, InputDeviceExecuteCommandDelegate executeCommandDelegate) { }

	[Address(RVA = "0x29D3380", Offset = "0x29D2780", Length = "0x156")]
	[Token(Token = "0x6000C63")]
	private static string SanitizeString(string original, bool allowPaths = false) { }

}

