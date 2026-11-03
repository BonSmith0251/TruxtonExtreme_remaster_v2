namespace UnityEngine.Rendering;

[Token(Token = "0x20001F6")]
public class VolumeComponent : ScriptableObject
{
	[CompilerGenerated]
	[Token(Token = "0x20001F8")]
	private sealed class <>c
	{
		[Token(Token = "0x400097A")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400097B")]
		public static Func<FieldInfo, Int32> <>9__10_0; //Field offset: 0x8

		[Address(RVA = "0x2C67DE0", Offset = "0x2C671E0", Length = "0x67")]
		[Token(Token = "0x6000EEE")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000EEF")]
		public <>c() { }

		[Address(RVA = "0xA50640", Offset = "0xA4FA40", Length = "0x2C")]
		[Token(Token = "0x6000EF0")]
		internal int <FindParameters>b__10_0(FieldInfo t) { }

	}

	[Token(Token = "0x20001F7")]
	internal sealed class Indent : PropertyAttribute
	{
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000979")]
		public readonly int relativeAmount; //Field offset: 0x18

		[Address(RVA = "0x2C5F130", Offset = "0x2C5E530", Length = "0x24")]
		[Token(Token = "0x6000EED")]
		public Indent(int relativeAmount = 1) { }

	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000975")]
	public bool active; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000976")]
	private string <displayName>k__BackingField; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000977")]
	internal VolumeParameter[] parameterList; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000978")]
	private ReadOnlyCollection<VolumeParameter> m_ParameterReadOnlyCollection; //Field offset: 0x30

	[Obsolete("Use DisplayInfo attribute to define a display name instead. #from(6000.3)", False)]
	[Token(Token = "0x170001E7")]
	public string displayName
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000EDF")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000EE0")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170001E8")]
	public ReadOnlyCollection<VolumeParameter> parameters
	{
		[Address(RVA = "0x2C6A060", Offset = "0x2C69460", Length = "0x8C")]
		[Token(Token = "0x6000EE1")]
		 get { } //Length: 140
	}

	[Address(RVA = "0x2C6A050", Offset = "0x2C69450", Length = "0xB")]
	[Token(Token = "0x6000EEC")]
	public VolumeComponent() { }

	[Address(RVA = "0x2C69360", Offset = "0x2C68760", Length = "0x99")]
	[Token(Token = "0x6000EE9")]
	public bool AnyPropertiesIsOverridden() { }

	[Address(RVA = "0x2C69400", Offset = "0x2C68800", Length = "0x482")]
	[Token(Token = "0x6000EE2")]
	internal static void FindParameters(object o, List<VolumeParameter> parameters, Func<FieldInfo, Boolean> filter = null) { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000EDF")]
	public string get_displayName() { }

	[Address(RVA = "0x2C6A060", Offset = "0x2C69460", Length = "0x8C")]
	[Token(Token = "0x6000EE1")]
	public ReadOnlyCollection<VolumeParameter> get_parameters() { }

	[Address(RVA = "0x2C69890", Offset = "0x2C68C90", Length = "0x9C")]
	[Token(Token = "0x6000EE8")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2C69930", Offset = "0x2C68D30", Length = "0x7")]
	[Token(Token = "0x6000EEA")]
	protected override void OnDestroy() { }

	[Address(RVA = "0x2C69940", Offset = "0x2C68D40", Length = "0x6A")]
	[Token(Token = "0x6000EE4")]
	protected override void OnDisable() { }

	[Address(RVA = "0x2C699B0", Offset = "0x2C68DB0", Length = "0x1DD")]
	[Token(Token = "0x6000EE3")]
	protected override void OnEnable() { }

	[Address(RVA = "0x2C69B90", Offset = "0x2C68F90", Length = "0x149")]
	[Token(Token = "0x6000EE5")]
	public override void Override(VolumeComponent state, float interpFactor) { }

	[Address(RVA = "0x2C69CE0", Offset = "0x2C690E0", Length = "0x86")]
	[Token(Token = "0x6000EEB")]
	public void Release() { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000EE0")]
	protected void set_displayName(string value) { }

	[Address(RVA = "0x2C69D70", Offset = "0x2C69170", Length = "0x10")]
	[Token(Token = "0x6000EE6")]
	public void SetAllOverridesTo(bool state) { }

	[Address(RVA = "0x2C69D80", Offset = "0x2C69180", Length = "0x2CC")]
	[Token(Token = "0x6000EE7")]
	internal void SetOverridesTo(IEnumerable<VolumeParameter> enumerable, bool state) { }

}

