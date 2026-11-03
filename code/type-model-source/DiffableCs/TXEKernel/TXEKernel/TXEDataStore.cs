namespace TXEKernel;

[Token(Token = "0x200001A")]
public class TXEDataStore : SimpleSingleton<TXEDataStore>
{
	[CompilerGenerated]
	[Token(Token = "0x200001C")]
	private sealed class <>c
	{
		[Token(Token = "0x400008B")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400008C")]
		public static Action<Response> <>9__49_0; //Field offset: 0x8

		[Address(RVA = "0x26EA0E0", Offset = "0x26E94E0", Length = "0x67")]
		[Token(Token = "0x6000086")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000087")]
		public <>c() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000088")]
		internal void <SaveSync>b__49_0(Response response) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200001D")]
	private sealed class <Initialize>d__1 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400008D")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400008E")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400008F")]
		public TXEDataStore <>4__this; //Field offset: 0x20

		[Token(Token = "0x17000018")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600008C")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000019")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600008E")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000089")]
		public <Initialize>d__1(int <>1__state) { }

		[Address(RVA = "0x26E69A0", Offset = "0x26E5DA0", Length = "0x2BB")]
		[Token(Token = "0x600008B")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600008C")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600008E")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x26E6C60", Offset = "0x26E6060", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600008D")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600008A")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200001E")]
	private sealed class <IsExistsSaveData>d__46 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000090")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000091")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000092")]
		public Action<Boolean> cb; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000093")]
		public TXEDataStore <>4__this; //Field offset: 0x28

		[Token(Token = "0x1700001A")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000092")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700001B")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000094")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600008F")]
		public <IsExistsSaveData>d__46(int <>1__state) { }

		[Address(RVA = "0x26E6CA0", Offset = "0x26E60A0", Length = "0x55")]
		[Token(Token = "0x6000091")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000092")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000094")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x26E6D00", Offset = "0x26E6100", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000093")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000090")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200001F")]
	private sealed class <Load>d__50 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000094")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000095")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000096")]
		public TXEDataStore <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000097")]
		public Action<Response> onLoaded; //Field offset: 0x28

		[Token(Token = "0x1700001C")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000098")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700001D")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600009A")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000095")]
		public <Load>d__50(int <>1__state) { }

		[Address(RVA = "0x26E7A30", Offset = "0x26E6E30", Length = "0x153")]
		[Token(Token = "0x6000097")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000098")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600009A")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x26E7B90", Offset = "0x26E6F90", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000099")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000096")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000020")]
	private struct <LoadUniTask>d__51 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000098")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000099")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400009A")]
		public TXEDataStore <>4__this; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400009B")]
		public Action<Response> onLoaded; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400009C")]
		private Awaiter<Response> <>u__1; //Field offset: 0x28

		[Address(RVA = "0x26E7BD0", Offset = "0x26E6FD0", Length = "0x362")]
		[Token(Token = "0x600009B")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x600009C")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000021")]
	private sealed class <Save>d__47 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400009D")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400009E")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400009F")]
		public TXEDataStore <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000A0")]
		public Action<Response> onSaved; //Field offset: 0x28

		[Token(Token = "0x1700001E")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60000A0")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700001F")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60000A2")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600009D")]
		public <Save>d__47(int <>1__state) { }

		[Address(RVA = "0x26E8F30", Offset = "0x26E8330", Length = "0x80")]
		[Token(Token = "0x600009F")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60000A0")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60000A2")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x26E8FC0", Offset = "0x26E83C0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60000A1")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600009E")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000022")]
	private struct <SaveSync>d__49 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000A1")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000A2")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000A3")]
		public TXEDataStore <>4__this; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000A4")]
		private Awaiter <>u__1; //Field offset: 0x20

		[Address(RVA = "0x26E8C00", Offset = "0x26E8000", Length = "0x325")]
		[Token(Token = "0x60000A3")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x60000A4")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000023")]
	private struct <SaveUniTask>d__48 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000A5")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000A6")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000A7")]
		public TXEDataStore <>4__this; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000A8")]
		public Action<Response> onSaved; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000A9")]
		private Awaiter<Response> <>u__1; //Field offset: 0x28

		[Address(RVA = "0x26E9000", Offset = "0x26E8400", Length = "0x387")]
		[Token(Token = "0x60000A5")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x60000A6")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x200001B")]
	internal enum ErrorCode : int
	{
		None = 0,
		IOExp = 1,
		UnauthorizedAccessExp = 2,
		SecurityExp = 3,
		DirectryNotFoundExp = 4,
		UnexpectExp = 5,
		FileNotFound = 6,
		PathTooLong = 7,
		NoSpace = 8,
		Broken = 9,
		UnExtractable = 10,
	}

	[Token(Token = "0x4000075")]
	private static readonly BitArray _maskData; //Field offset: 0x0
	[Token(Token = "0x400007E")]
	private static readonly string _saveFileName; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000076")]
	public CryptData _cryptData; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000077")]
	private readonly string _SAVEVERSION; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000078")]
	private readonly string _VERSION; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000079")]
	private readonly string _VALIDVERSION; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400007A")]
	private MenuStatus _menuStatus; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400007B")]
	private PlayedRecords _playedRecords; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400007C")]
	private GameSetting _gameSetting; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400007D")]
	private StorySaveData _storySaveData; //Field offset: 0x48

	[Token(Token = "0x17000012")]
	private static Byte[] _cryptKey
	{
		[Address(RVA = "0x26E2130", Offset = "0x26E1530", Length = "0x5D")]
		[Token(Token = "0x6000073")]
		private get { } //Length: 93
	}

	[Token(Token = "0x17000016")]
	public static GameSetting gameSetting
	{
		[Address(RVA = "0x26E2190", Offset = "0x26E1590", Length = "0x75")]
		[Token(Token = "0x6000077")]
		 get { } //Length: 117
	}

	[Token(Token = "0x17000014")]
	public static MenuStatus menuStatus
	{
		[Address(RVA = "0x26E2210", Offset = "0x26E1610", Length = "0x75")]
		[Token(Token = "0x6000075")]
		 get { } //Length: 117
	}

	[Token(Token = "0x17000015")]
	public static PlayedRecords playedRecords
	{
		[Address(RVA = "0x26E2290", Offset = "0x26E1690", Length = "0x75")]
		[Token(Token = "0x6000076")]
		 get { } //Length: 117
	}

	[Token(Token = "0x17000013")]
	public string SavePath
	{
		[Address(RVA = "0x26E20C0", Offset = "0x26E14C0", Length = "0x6C")]
		[Token(Token = "0x6000074")]
		 get { } //Length: 108
	}

	[Token(Token = "0x17000017")]
	public static StorySaveData storySaveData
	{
		[Address(RVA = "0x26E2310", Offset = "0x26E1710", Length = "0x75")]
		[Token(Token = "0x6000078")]
		 get { } //Length: 117
	}

	[Address(RVA = "0x26E1D80", Offset = "0x26E1180", Length = "0x78")]
	[Token(Token = "0x6000079")]
	private void _Initialize() { }

	[Address(RVA = "0x26E1E00", Offset = "0x26E1200", Length = "0x101")]
	[Token(Token = "0x6000085")]
	private static TXEDataStore() { }

	[Address(RVA = "0x26E1F10", Offset = "0x26E1310", Length = "0x1A1")]
	[Token(Token = "0x6000084")]
	public TXEDataStore() { }

	[Address(RVA = "0x26E0E30", Offset = "0x26E0230", Length = "0x4C")]
	[Token(Token = "0x6000072")]
	public TXEErrors ChangeErrorCode(Response response) { }

	[Address(RVA = "0x26E0F00", Offset = "0x26E0300", Length = "0xB0")]
	[Token(Token = "0x600005E")]
	public void Clear() { }

	[Address(RVA = "0x26E0EB0", Offset = "0x26E02B0", Length = "0x49")]
	[Token(Token = "0x600006B")]
	public void Clear(string key = null) { }

	[Address(RVA = "0x26E0EB0", Offset = "0x26E02B0", Length = "0x49")]
	[Token(Token = "0x600006C")]
	public void ClearInt64(string key) { }

	[Address(RVA = "0x26E0FC0", Offset = "0x26E03C0", Length = "0xAE")]
	[Token(Token = "0x6000081")]
	public void DeleteAll() { }

	[Address(RVA = "0x26E1070", Offset = "0x26E0470", Length = "0x49")]
	[Token(Token = "0x6000060")]
	public void DeleteKey(string key) { }

	[Address(RVA = "0x26E10C0", Offset = "0x26E04C0", Length = "0x18")]
	[Token(Token = "0x6000071")]
	public TXEErrors ErrorCodeChange(Response res) { }

	[Address(RVA = "0x93FF50", Offset = "0x93F350", Length = "0x11B")]
	[Token(Token = "0x600006D")]
	public T Get(string key) { }

	[Address(RVA = "0x26E2130", Offset = "0x26E1530", Length = "0x5D")]
	[Token(Token = "0x6000073")]
	private static Byte[] get__cryptKey() { }

	[Address(RVA = "0x26E2190", Offset = "0x26E1590", Length = "0x75")]
	[Token(Token = "0x6000077")]
	public static GameSetting get_gameSetting() { }

	[Address(RVA = "0x26E2210", Offset = "0x26E1610", Length = "0x75")]
	[Token(Token = "0x6000075")]
	public static MenuStatus get_menuStatus() { }

	[Address(RVA = "0x26E2290", Offset = "0x26E1690", Length = "0x75")]
	[Token(Token = "0x6000076")]
	public static PlayedRecords get_playedRecords() { }

	[Address(RVA = "0x26E20C0", Offset = "0x26E14C0", Length = "0x6C")]
	[Token(Token = "0x6000074")]
	public string get_SavePath() { }

	[Address(RVA = "0x26E2310", Offset = "0x26E1710", Length = "0x75")]
	[Token(Token = "0x6000078")]
	public static StorySaveData get_storySaveData() { }

	[Address(RVA = "0x26E1140", Offset = "0x26E0540", Length = "0x8A")]
	[Token(Token = "0x6000062")]
	public Dictionary<String, ValueTuple`2<Int32, String>> GetDict() { }

	[Address(RVA = "0x26E11D0", Offset = "0x26E05D0", Length = "0x49")]
	[Token(Token = "0x6000067")]
	public float GetFloat(string key) { }

	[Address(RVA = "0x26E1270", Offset = "0x26E0670", Length = "0x49")]
	[Token(Token = "0x6000065")]
	public int GetInt(string key) { }

	[Address(RVA = "0x26E1220", Offset = "0x26E0620", Length = "0x49")]
	[Token(Token = "0x6000069")]
	public long GetInt64(string key) { }

	[Address(RVA = "0x26E12C0", Offset = "0x26E06C0", Length = "0x49")]
	[Token(Token = "0x6000063")]
	public string GetString(string key) { }

	[Address(RVA = "0x26E1310", Offset = "0x26E0710", Length = "0x1A9")]
	[Token(Token = "0x6000070")]
	private ValueTuple<Int32, Int32, Int32> GetVersion() { }

	[Address(RVA = "0x26E14C0", Offset = "0x26E08C0", Length = "0x49")]
	[Token(Token = "0x6000061")]
	public bool HasKey(string key) { }

	[Address(RVA = "0x26E1510", Offset = "0x26E0910", Length = "0x67")]
	[IteratorStateMachine(typeof(<Initialize>d__1))]
	[Token(Token = "0x600005D")]
	public IEnumerator Initialize() { }

	[Address(RVA = "0x26E1580", Offset = "0x26E0980", Length = "0x8C")]
	[Token(Token = "0x600005F")]
	public bool IsChanged() { }

	[Address(RVA = "0x26E1610", Offset = "0x26E0A10", Length = "0x84")]
	[IteratorStateMachine(typeof(<IsExistsSaveData>d__46))]
	[Token(Token = "0x600007B")]
	public IEnumerator IsExistsSaveData(Action<Boolean> cb) { }

	[Address(RVA = "0x26E1790", Offset = "0x26E0B90", Length = "0x84")]
	[IteratorStateMachine(typeof(<Load>d__50))]
	[Token(Token = "0x600007F")]
	public IEnumerator Load(Action<Response> onLoaded = null) { }

	[Address(RVA = "0x26E16A0", Offset = "0x26E0AA0", Length = "0xEF")]
	[AsyncStateMachine(typeof(<LoadUniTask>d__51))]
	[Token(Token = "0x6000080")]
	public UniTask LoadUniTask(Action<Response> onLoaded = null) { }

	[Address(RVA = "0x26E19D0", Offset = "0x26E0DD0", Length = "0x84")]
	[IteratorStateMachine(typeof(<Save>d__47))]
	[Token(Token = "0x600007C")]
	public IEnumerator Save(Action<Response> onSaved = null) { }

	[Address(RVA = "0x26E1820", Offset = "0x26E0C20", Length = "0xBD")]
	[AsyncStateMachine(typeof(<SaveSync>d__49))]
	[Token(Token = "0x600007E")]
	public UniTask SaveSync() { }

	[Address(RVA = "0x26E18E0", Offset = "0x26E0CE0", Length = "0xEF")]
	[AsyncStateMachine(typeof(<SaveUniTask>d__48))]
	[Token(Token = "0x600007D")]
	public UniTask SaveUniTask(Action<Response> onSaved = null) { }

	[Address(RVA = "0x940070", Offset = "0x93F470", Length = "0xEF")]
	[Token(Token = "0x600006E")]
	public void Set(string key, T value) { }

	[Address(RVA = "0x26E1A60", Offset = "0x26E0E60", Length = "0x5A")]
	[Token(Token = "0x6000068")]
	public void SetFloat(string key, float value) { }

	[Address(RVA = "0x26E1B20", Offset = "0x26E0F20", Length = "0x58")]
	[Token(Token = "0x6000066")]
	public void SetInt(string key, int value) { }

	[Address(RVA = "0x26E1AC0", Offset = "0x26E0EC0", Length = "0x59")]
	[Token(Token = "0x600006A")]
	public void SetInt64(string key, long value) { }

	[Address(RVA = "0x26E1B80", Offset = "0x26E0F80", Length = "0x59")]
	[Token(Token = "0x6000064")]
	public void SetString(string key, string value) { }

	[Address(RVA = "0x26E1BE0", Offset = "0x26E0FE0", Length = "0x5E")]
	[Token(Token = "0x600006F")]
	public void SetVersion() { }

	[Address(RVA = "0x26E1C40", Offset = "0x26E1040", Length = "0x8A")]
	[Token(Token = "0x6000082")]
	public string ShowPlayerPrefsDirctory() { }

	[Address(RVA = "0x26E1CD0", Offset = "0x26E10D0", Length = "0x40")]
	[Token(Token = "0x600007A")]
	public void Terminate() { }

	[Address(RVA = "0x26E1D10", Offset = "0x26E1110", Length = "0x6E")]
	[Token(Token = "0x6000083")]
	private void VersionDataCheck() { }

}

