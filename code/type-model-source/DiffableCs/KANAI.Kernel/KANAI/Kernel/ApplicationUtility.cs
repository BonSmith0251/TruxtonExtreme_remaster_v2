namespace KANAI.Kernel;

[Token(Token = "0x2000005")]
public static class ApplicationUtility
{
	[CompilerGenerated]
	[Token(Token = "0x2000007")]
	private sealed class <_ResetCoroutine>d__18 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000013")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000014")]
		private object <>2__current; //Field offset: 0x18

		[Token(Token = "0x17000007")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600003E")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000008")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000040")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600003B")]
		public <_ResetCoroutine>d__18(int <>1__state) { }

		[Address(RVA = "0x1DF52E0", Offset = "0x1DF46E0", Length = "0x16C")]
		[Token(Token = "0x600003D")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600003E")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000040")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1DF5450", Offset = "0x1DF4850", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600003F")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600003C")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000006")]
	private sealed class <SetupAssetLoader>d__15 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000011")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000012")]
		private object <>2__current; //Field offset: 0x18

		[Token(Token = "0x17000005")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000038")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000006")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600003A")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000035")]
		public <SetupAssetLoader>d__15(int <>1__state) { }

		[Address(RVA = "0x1DF47D0", Offset = "0x1DF3BD0", Length = "0xF4")]
		[Token(Token = "0x6000037")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000038")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600003A")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1DF48D0", Offset = "0x1DF3CD0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000039")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000036")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x4000006")]
	private static string _DataDateString; //Field offset: 0x0
	[Token(Token = "0x400000F")]
	public const float TARGET_ASPECT = 1.7777778; //Field offset: 0x0
	[Token(Token = "0x4000007")]
	public static MonoBehaviour bootRoot; //Field offset: 0x8
	[CompilerGenerated]
	[Token(Token = "0x4000008")]
	private static Action onSoftwareReset; //Field offset: 0x10
	[Token(Token = "0x4000009")]
	public static Func<IEnumerator> onSoftwareReboot; //Field offset: 0x18
	[CompilerGenerated]
	[Token(Token = "0x400000A")]
	private static bool <IsReseting>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[Token(Token = "0x400000B")]
	private static bool <IsReady>k__BackingField; //Field offset: 0x21
	[Token(Token = "0x400000C")]
	private static Vector2 _ScreenSize; //Field offset: 0x24
	[Token(Token = "0x400000D")]
	public static readonly float targetFrameRate; //Field offset: 0x2C
	[Token(Token = "0x400000E")]
	public static readonly float targetMaxFrameRate; //Field offset: 0x30
	[CompilerGenerated]
	[Token(Token = "0x4000010")]
	private static string <PersistentDataPath>k__BackingField; //Field offset: 0x38

	[Token(Token = "0x14000001")]
	public static event Action onSoftwareReset
	{
		[Address(RVA = "0x1DE3B00", Offset = "0x1DE2F00", Length = "0xF2")]
		[CompilerGenerated]
		[Token(Token = "0x6000027")]
		 add { } //Length: 242
		[Address(RVA = "0x1DE3D50", Offset = "0x1DE3150", Length = "0xF2")]
		[CompilerGenerated]
		[Token(Token = "0x6000028")]
		 remove { } //Length: 242
	}

	[Token(Token = "0x17000002")]
	public private static bool IsReady
	{
		[Address(RVA = "0x1DE3C00", Offset = "0x1DE3000", Length = "0x4F")]
		[CompilerGenerated]
		[Token(Token = "0x600002B")]
		 get { } //Length: 79
		[Address(RVA = "0x1DE3E50", Offset = "0x1DE3250", Length = "0x54")]
		[CompilerGenerated]
		[Token(Token = "0x600002C")]
		private set { } //Length: 84
	}

	[Token(Token = "0x17000001")]
	public private static bool IsReseting
	{
		[Address(RVA = "0x1DE3C50", Offset = "0x1DE3050", Length = "0x4F")]
		[CompilerGenerated]
		[Token(Token = "0x6000029")]
		 get { } //Length: 79
		[Address(RVA = "0x1DE3EB0", Offset = "0x1DE32B0", Length = "0x54")]
		[CompilerGenerated]
		[Token(Token = "0x600002A")]
		private set { } //Length: 84
	}

	[Token(Token = "0x17000004")]
	public private static string PersistentDataPath
	{
		[Address(RVA = "0x1DE3CA0", Offset = "0x1DE30A0", Length = "0x4F")]
		[CompilerGenerated]
		[Token(Token = "0x6000031")]
		 get { } //Length: 79
		[Address(RVA = "0x1DE3F10", Offset = "0x1DE3310", Length = "0x6E")]
		[CompilerGenerated]
		[Token(Token = "0x6000032")]
		private set { } //Length: 110
	}

	[Token(Token = "0x17000003")]
	public static Vector2 ScreenSize
	{
		[Address(RVA = "0x1DE3CF0", Offset = "0x1DE30F0", Length = "0x5D")]
		[Token(Token = "0x600002D")]
		 get { } //Length: 93
	}

	[Address(RVA = "0x1DE38E0", Offset = "0x1DE2CE0", Length = "0x4B")]
	[IteratorStateMachine(typeof(<_ResetCoroutine>d__18))]
	[Token(Token = "0x6000025")]
	private static IEnumerator _ResetCoroutine() { }

	[Address(RVA = "0x1DE3930", Offset = "0x1DE2D30", Length = "0x1CF")]
	[Token(Token = "0x6000034")]
	private static ApplicationUtility() { }

	[Address(RVA = "0x1DE3B00", Offset = "0x1DE2F00", Length = "0xF2")]
	[CompilerGenerated]
	[Token(Token = "0x6000027")]
	public static void add_onSoftwareReset(Action value) { }

	[Address(RVA = "0x1DE3C00", Offset = "0x1DE3000", Length = "0x4F")]
	[CompilerGenerated]
	[Token(Token = "0x600002B")]
	public static bool get_IsReady() { }

	[Address(RVA = "0x1DE3C50", Offset = "0x1DE3050", Length = "0x4F")]
	[CompilerGenerated]
	[Token(Token = "0x6000029")]
	public static bool get_IsReseting() { }

	[Address(RVA = "0x1DE3CA0", Offset = "0x1DE30A0", Length = "0x4F")]
	[CompilerGenerated]
	[Token(Token = "0x6000031")]
	public static string get_PersistentDataPath() { }

	[Address(RVA = "0x1DE3CF0", Offset = "0x1DE30F0", Length = "0x5D")]
	[Token(Token = "0x600002D")]
	public static Vector2 get_ScreenSize() { }

	[Address(RVA = "0x1DE2810", Offset = "0x1DE1C10", Length = "0x15D")]
	[Token(Token = "0x6000030")]
	public static Rect GetAspectRect() { }

	[Address(RVA = "0x1DE2970", Offset = "0x1DE1D70", Length = "0x149")]
	[Token(Token = "0x6000015")]
	public static string GetPlatformName() { }

	[Address(RVA = "0x1DE2AC0", Offset = "0x1DE1EC0", Length = "0x105")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	[Token(Token = "0x600002F")]
	private static void InitializeScreenSize() { }

	[Address(RVA = "0x1DE2BD0", Offset = "0x1DE1FD0", Length = "0x2FA")]
	[Token(Token = "0x600001F")]
	public static bool IsCommonMonitor() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x600001E")]
	public static bool IsHandheld() { }

	[Address(RVA = "0x1DE2ED0", Offset = "0x1DE22D0", Length = "0xD1")]
	[Token(Token = "0x600001C")]
	public static bool IsNintendo() { }

	[Address(RVA = "0x1DE3050", Offset = "0x1DE2450", Length = "0xD1")]
	[Token(Token = "0x6000016")]
	public static bool IsPlayStation() { }

	[Address(RVA = "0x1DE2FB0", Offset = "0x1DE23B0", Length = "0x47")]
	[Token(Token = "0x6000017")]
	public static bool IsPlayStation4() { }

	[Address(RVA = "0x1DE3000", Offset = "0x1DE2400", Length = "0x47")]
	[Token(Token = "0x6000018")]
	public static bool IsPlayStation5() { }

	[Address(RVA = "0x1DE3180", Offset = "0x1DE2580", Length = "0x47")]
	[Token(Token = "0x6000019")]
	public static bool IsSwitch() { }

	[Address(RVA = "0x1DE3130", Offset = "0x1DE2530", Length = "0x47")]
	[Token(Token = "0x600001A")]
	public static bool IsSwitch2() { }

	[Address(RVA = "0x1DE31D0", Offset = "0x1DE25D0", Length = "0x90")]
	[Token(Token = "0x600001D")]
	public static bool IsWindows() { }

	[Address(RVA = "0x1DE3260", Offset = "0x1DE2660", Length = "0x6F")]
	[Token(Token = "0x600001B")]
	public static bool IsXbox() { }

	[Address(RVA = "0x1DE32D0", Offset = "0x1DE26D0", Length = "0x9C")]
	[Token(Token = "0x6000033")]
	public static void OverridePersistentDataPath(string dataPath) { }

	[Address(RVA = "0x1DE3370", Offset = "0x1DE2770", Length = "0x40")]
	[Token(Token = "0x6000021")]
	public static void Quit() { }

	[Address(RVA = "0x1DE3D50", Offset = "0x1DE3150", Length = "0xF2")]
	[CompilerGenerated]
	[Token(Token = "0x6000028")]
	public static void remove_onSoftwareReset(Action value) { }

	[Address(RVA = "0x1DE33B0", Offset = "0x1DE27B0", Length = "0x14F")]
	[RuntimeInitializeOnLoadMethod]
	[Token(Token = "0x6000013")]
	public static void ResetAll() { }

	[Address(RVA = "0x1DE3E50", Offset = "0x1DE3250", Length = "0x54")]
	[CompilerGenerated]
	[Token(Token = "0x600002C")]
	private static void set_IsReady(bool value) { }

	[Address(RVA = "0x1DE3EB0", Offset = "0x1DE32B0", Length = "0x54")]
	[CompilerGenerated]
	[Token(Token = "0x600002A")]
	private static void set_IsReseting(bool value) { }

	[Address(RVA = "0x1DE3F10", Offset = "0x1DE3310", Length = "0x6E")]
	[CompilerGenerated]
	[Token(Token = "0x6000032")]
	private static void set_PersistentDataPath(string value) { }

	[Address(RVA = "0x1DE3500", Offset = "0x1DE2900", Length = "0x69")]
	[Token(Token = "0x6000026")]
	public static void SetDataDate(string tstr) { }

	[Address(RVA = "0x1DE3570", Offset = "0x1DE2970", Length = "0x8A")]
	[Token(Token = "0x6000023")]
	public static void SetReady() { }

	[Address(RVA = "0x1DE3600", Offset = "0x1DE2A00", Length = "0x66")]
	[Token(Token = "0x600002E")]
	public static void SetScreenSize(Vector2 screenSize) { }

	[Address(RVA = "0x1DE3670", Offset = "0x1DE2A70", Length = "0x4B")]
	[IteratorStateMachine(typeof(<SetupAssetLoader>d__15))]
	[Token(Token = "0x6000022")]
	public static IEnumerator SetupAssetLoader() { }

	[Address(RVA = "0x1DE36C0", Offset = "0x1DE2AC0", Length = "0x1B2")]
	[Token(Token = "0x6000024")]
	public static void SoftwareReset() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000020")]
	public static void Start() { }

	[Address(RVA = "0x1DE3880", Offset = "0x1DE2C80", Length = "0x5E")]
	[Token(Token = "0x6000014")]
	public static string Version() { }

}

