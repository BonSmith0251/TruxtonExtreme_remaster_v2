namespace UnityEngine.Rendering;

[Token(Token = "0x200006A")]
public abstract class DebugDisplaySettings : IDebugDisplaySettings
{
	[CompilerGenerated]
	[Token(Token = "0x200006C")]
	private sealed class <>c
	{
		[Token(Token = "0x400015D")]
		public static readonly <>c<T> <>9; //Field offset: 0x0

		[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
		[Token(Token = "0x600058B")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600058C")]
		public <>c() { }

		[Address(RVA = "0xA36230", Offset = "0xA35630", Length = "0x60")]
		[Token(Token = "0x600058D")]
		internal T <.cctor>b__17_0() { }

	}

	[Token(Token = "0x200006B")]
	private class IDebugDisplaySettingsDataComparer : IEqualityComparer<IDebugDisplaySettingsData>
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600058A")]
		public IDebugDisplaySettingsDataComparer() { }

		[Address(RVA = "0x1C73440", Offset = "0x1C72840", Length = "0x77")]
		[Token(Token = "0x6000588")]
		public override bool Equals(IDebugDisplaySettingsData x, IDebugDisplaySettingsData y) { }

		[Address(RVA = "0x1C734C0", Offset = "0x1C728C0", Length = "0x41")]
		[Token(Token = "0x6000589")]
		public override int GetHashCode(IDebugDisplaySettingsData obj) { }

	}

	[Token(Token = "0x400015C")]
	private static readonly Lazy<T> s_Instance; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400015B")]
	protected readonly HashSet<IDebugDisplaySettingsData> m_Settings; //Field offset: 0x0

	[Token(Token = "0x1700004A")]
	public override bool AreAnySettingsActive
	{
		[Address(RVA = "0x17CECF0", Offset = "0x17CE0F0", Length = "0x13D")]
		[Token(Token = "0x600057E")]
		 get { } //Length: 317
	}

	[Token(Token = "0x17000049")]
	public static T Instance
	{
		[Address(RVA = "0xF52820", Offset = "0xF51C20", Length = "0xC6")]
		[Token(Token = "0x600057D")]
		 get { } //Length: 198
	}

	[Token(Token = "0x1700004C")]
	public override bool IsLightingActive
	{
		[Address(RVA = "0x17CF000", Offset = "0x17CE400", Length = "0x1CF")]
		[Token(Token = "0x6000580")]
		 get { } //Length: 463
	}

	[Token(Token = "0x1700004B")]
	public override bool IsPostProcessingAllowed
	{
		[Address(RVA = "0x17CF3A0", Offset = "0x17CE7A0", Length = "0x1CE")]
		[Token(Token = "0x600057F")]
		 get { } //Length: 462
	}

	[Address(RVA = "0x17CE7F0", Offset = "0x17CDBF0", Length = "0x214")]
	[Token(Token = "0x6000587")]
	private static DebugDisplaySettings`1() { }

	[Address(RVA = "0x17CEAE0", Offset = "0x17CDEE0", Length = "0xC9")]
	[Token(Token = "0x6000586")]
	protected DebugDisplaySettings`1() { }

	[Address(RVA = "0x699C50", Offset = "0x699050", Length = "0x57")]
	[Token(Token = "0x6000581")]
	protected TData Add(TData newData) { }

	[Address(RVA = "0x17CDBF0", Offset = "0x17CCFF0", Length = "0x127")]
	[Token(Token = "0x6000583")]
	public override void ForEach(Action<IDebugDisplaySettingsData> onExecute) { }

	[Address(RVA = "0x17CECF0", Offset = "0x17CE0F0", Length = "0x13D")]
	[Token(Token = "0x600057E")]
	public override bool get_AreAnySettingsActive() { }

	[Address(RVA = "0xF52820", Offset = "0xF51C20", Length = "0xC6")]
	[Token(Token = "0x600057D")]
	public static T get_Instance() { }

	[Address(RVA = "0x17CF000", Offset = "0x17CE400", Length = "0x1CF")]
	[Token(Token = "0x6000580")]
	public override bool get_IsLightingActive() { }

	[Address(RVA = "0x17CF3A0", Offset = "0x17CE7A0", Length = "0x1CE")]
	[Token(Token = "0x600057F")]
	public override bool get_IsPostProcessingAllowed() { }

	[Address(RVA = "0x17CDE50", Offset = "0x17CD250", Length = "0x1E7")]
	[Token(Token = "0x6000584")]
	public override void Reset() { }

	[Address(RVA = "0x17CE380", Offset = "0x17CD780", Length = "0x14F")]
	[Token(Token = "0x6000585")]
	public override bool TryGetScreenClearColor(ref Color color) { }

	[Address(RVA = "0x17CE4D0", Offset = "0x17CD8D0", Length = "0x57")]
	[Token(Token = "0x6000582")]
	private override IDebugDisplaySettingsData UnityEngine.Rendering.IDebugDisplaySettings.Add(IDebugDisplaySettingsData newData) { }

}

