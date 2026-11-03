namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x2000034")]
public sealed class AdaptivePerformanceManagerSettings : ScriptableObject
{
	[CompilerGenerated]
	[Token(Token = "0x2000035")]
	private sealed class <InitializeLoader>d__21 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000CF")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000D0")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000D1")]
		public AdaptivePerformanceManagerSettings <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000D2")]
		private Enumerator<AdaptivePerformanceLoader> <>s__1; //Field offset: 0x28
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40000D3")]
		private AdaptivePerformanceLoader <loader>5__2; //Field offset: 0x40

		[Token(Token = "0x17000082")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600018D")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000083")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600018F")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000189")]
		public <InitializeLoader>d__21(int <>1__state) { }

		[Address(RVA = "0x2F99F70", Offset = "0x2F99370", Length = "0x41")]
		[Token(Token = "0x600018C")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x2F99AD0", Offset = "0x2F98ED0", Length = "0x3CB")]
		[Token(Token = "0x600018B")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600018D")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600018F")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2F99EA0", Offset = "0x2F992A0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600018E")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2F99EE0", Offset = "0x2F992E0", Length = "0x83")]
		[DebuggerHidden]
		[Token(Token = "0x600018A")]
		private override void System.IDisposable.Dispose() { }

	}

	[HideInInspector]
	[Token(Token = "0x40000CE")]
	private static AdaptivePerformanceLoader s_ActiveLoader; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[HideInInspector]
	[Token(Token = "0x40000CA")]
	private bool m_InitializationComplete; //Field offset: 0x18
	[FieldOffset(Offset = "0x19")]
	[SerializeField]
	[Token(Token = "0x40000CB")]
	[Tooltip("Determines if the Adaptive Performance Manager instance is responsible for creating and destroying the appropriate loader instance.")]
	private bool m_AutomaticLoading; //Field offset: 0x19
	[FieldOffset(Offset = "0x1A")]
	[SerializeField]
	[Token(Token = "0x40000CC")]
	[Tooltip("Determines if the Adaptive Performance Manager instance is responsible for starting and stopping subsystems for the active loader instance.")]
	private bool m_AutomaticRunning; //Field offset: 0x1A
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40000CD")]
	[Tooltip("List of Adaptive Performance Loader instances arranged in desired load order.")]
	private List<AdaptivePerformanceLoader> m_Loaders; //Field offset: 0x20

	[HideInInspector]
	[Token(Token = "0x17000081")]
	public private AdaptivePerformanceLoader activeLoader
	{
		[Address(RVA = "0x2F8BC50", Offset = "0x2F8B050", Length = "0x36")]
		[Token(Token = "0x600017E")]
		 get { } //Length: 54
		[Address(RVA = "0x2F8BCD0", Offset = "0x2F8B0D0", Length = "0x51")]
		[Token(Token = "0x600017F")]
		private set { } //Length: 81
	}

	[Token(Token = "0x1700007D")]
	public bool automaticLoading
	{
		[Address(RVA = "0x2F8BC90", Offset = "0x2F8B090", Length = "0x7")]
		[Token(Token = "0x6000177")]
		 get { } //Length: 7
		[Address(RVA = "0x21BAC10", Offset = "0x21BA010", Length = "0x4")]
		[Token(Token = "0x6000178")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700007E")]
	public bool automaticRunning
	{
		[Address(RVA = "0x2F8BCA0", Offset = "0x2F8B0A0", Length = "0x7")]
		[Token(Token = "0x6000179")]
		 get { } //Length: 7
		[Address(RVA = "0x21BAC00", Offset = "0x21BA000", Length = "0x4")]
		[Token(Token = "0x600017A")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000080")]
	public bool isInitializationComplete
	{
		[Address(RVA = "0x2F8BCB0", Offset = "0x2F8B0B0", Length = "0x7")]
		[Token(Token = "0x600017D")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700007F")]
	public List<AdaptivePerformanceLoader> loaders
	{
		[Address(RVA = "0x2F8BCC0", Offset = "0x2F8B0C0", Length = "0x7")]
		[Token(Token = "0x600017B")]
		 get { } //Length: 7
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x600017C")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2F8BBC0", Offset = "0x2F8AFC0", Length = "0x81")]
	[Token(Token = "0x6000188")]
	public AdaptivePerformanceManagerSettings() { }

	[Address(RVA = "0x6DC6D0", Offset = "0x6DBAD0", Length = "0x59")]
	[Token(Token = "0x6000180")]
	public T ActiveLoaderAs() { }

	[Address(RVA = "0x2F8B4E0", Offset = "0x2F8A8E0", Length = "0x179")]
	[Token(Token = "0x6000185")]
	internal void DeinitializeLoader() { }

	[Address(RVA = "0x2F8BC50", Offset = "0x2F8B050", Length = "0x36")]
	[Token(Token = "0x600017E")]
	public AdaptivePerformanceLoader get_activeLoader() { }

	[Address(RVA = "0x2F8BC90", Offset = "0x2F8B090", Length = "0x7")]
	[Token(Token = "0x6000177")]
	public bool get_automaticLoading() { }

	[Address(RVA = "0x2F8BCA0", Offset = "0x2F8B0A0", Length = "0x7")]
	[Token(Token = "0x6000179")]
	public bool get_automaticRunning() { }

	[Address(RVA = "0x2F8BCB0", Offset = "0x2F8B0B0", Length = "0x7")]
	[Token(Token = "0x600017D")]
	public bool get_isInitializationComplete() { }

	[Address(RVA = "0x2F8BCC0", Offset = "0x2F8B0C0", Length = "0x7")]
	[Token(Token = "0x600017B")]
	public List<AdaptivePerformanceLoader> get_loaders() { }

	[Address(RVA = "0x2F8B8E0", Offset = "0x2F8ACE0", Length = "0x67")]
	[IteratorStateMachine(typeof(<InitializeLoader>d__21))]
	[Token(Token = "0x6000182")]
	internal IEnumerator InitializeLoader() { }

	[Address(RVA = "0x2F8B660", Offset = "0x2F8AA60", Length = "0x27C")]
	[Token(Token = "0x6000181")]
	internal void InitializeLoaderSync() { }

	[Address(RVA = "0x2F8B950", Offset = "0x2F8AD50", Length = "0x10")]
	[Token(Token = "0x6000187")]
	private void OnDestroy() { }

	[Address(RVA = "0x2F8B960", Offset = "0x2F8AD60", Length = "0x16")]
	[Token(Token = "0x6000186")]
	private void OnDisable() { }

	[Address(RVA = "0x2F8BCD0", Offset = "0x2F8B0D0", Length = "0x51")]
	[Token(Token = "0x600017F")]
	private void set_activeLoader(AdaptivePerformanceLoader value) { }

	[Address(RVA = "0x21BAC10", Offset = "0x21BA010", Length = "0x4")]
	[Token(Token = "0x6000178")]
	public void set_automaticLoading(bool value) { }

	[Address(RVA = "0x21BAC00", Offset = "0x21BA000", Length = "0x4")]
	[Token(Token = "0x600017A")]
	public void set_automaticRunning(bool value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x600017C")]
	public void set_loaders(List<AdaptivePerformanceLoader> value) { }

	[Address(RVA = "0x2F8B980", Offset = "0x2F8AD80", Length = "0x117")]
	[Token(Token = "0x6000183")]
	internal void StartSubsystems() { }

	[Address(RVA = "0x2F8BAA0", Offset = "0x2F8AEA0", Length = "0x117")]
	[Token(Token = "0x6000184")]
	internal void StopSubsystems() { }

}

