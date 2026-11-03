namespace TXEKernel;

[Token(Token = "0x20000AA")]
public class TXEAEPlayer : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x20000BB")]
	private sealed class <>c
	{
		[Token(Token = "0x40003C4")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40003C5")]
		public static Func0<GameObject, String, Int32, Int32, Color, String, String, AVLayerStyleStrokeData, Rect, Component> <>9__26_1; //Field offset: 0x8
		[Token(Token = "0x40003C6")]
		public static Action<Component, Color> <>9__26_2; //Field offset: 0x10
		[Token(Token = "0x40003C7")]
		public static Func<Component, Vector2> <>9__26_3; //Field offset: 0x18

		[Address(RVA = "0x271FD90", Offset = "0x271F190", Length = "0x67")]
		[Token(Token = "0x60005EE")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60005EF")]
		public <>c() { }

		[Address(RVA = "0x271F3D0", Offset = "0x271E7D0", Length = "0x36E")]
		[Token(Token = "0x60005F0")]
		internal Component <Initialize>b__26_1(GameObject target, string fontName, int size, int line, Color color, string textData, string textId, AVLayerStyleStrokeData stroke, Rect boxRect) { }

		[Address(RVA = "0x271F740", Offset = "0x271EB40", Length = "0x90")]
		[Token(Token = "0x60005F1")]
		internal void <Initialize>b__26_2(Component component, Color color) { }

		[Address(RVA = "0x271F7D0", Offset = "0x271EBD0", Length = "0x9E")]
		[Token(Token = "0x60005F2")]
		internal Vector2 <Initialize>b__26_3(Component component) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000BC")]
	private sealed class <>c__DisplayClass29_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40003C8")]
		public TXEAEPlayer <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40003C9")]
		public List<String> markerTags; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40003CA")]
		public Action<AEAsAnimationRoot, Dictionary`2<String, List`1<MarkerData>>> onReady; //Field offset: 0x20

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60005F3")]
		public <>c__DisplayClass29_0() { }

		[Address(RVA = "0x271F900", Offset = "0x271ED00", Length = "0x3D")]
		[Token(Token = "0x60005F4")]
		internal void <Setup>b__0(AEAsAnimationRoot animationRoot) { }

		[Address(RVA = "0x271F940", Offset = "0x271ED40", Length = "0x1E")]
		[Token(Token = "0x60005F5")]
		internal void <Setup>b__1(AEAsAnimationRoot animationRoot) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000BD")]
	private sealed class <CoroutineWaitForReady>d__43 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40003CB")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40003CC")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40003CD")]
		public TXEAEPlayer <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40003CE")]
		private YieldInstruction <cacheWait>5__2; //Field offset: 0x28

		[Token(Token = "0x170001D5")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60005F9")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001D6")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60005FB")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60005F6")]
		public <CoroutineWaitForReady>d__43(int <>1__state) { }

		[Address(RVA = "0x271A2C0", Offset = "0x27196C0", Length = "0xEE")]
		[Token(Token = "0x60005F8")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60005F9")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60005FB")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x271A3B0", Offset = "0x27197B0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60005FA")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60005F7")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000BE")]
	private sealed class <CoroutineWaitForStop>d__44 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40003CF")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40003D0")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40003D1")]
		public TXEAEPlayer <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40003D2")]
		private YieldInstruction <cacheWait>5__2; //Field offset: 0x28

		[Token(Token = "0x170001D7")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60005FF")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001D8")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000601")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60005FC")]
		public <CoroutineWaitForStop>d__44(int <>1__state) { }

		[Address(RVA = "0x271A3F0", Offset = "0x27197F0", Length = "0xF7")]
		[Token(Token = "0x60005FE")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60005FF")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000601")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x271A610", Offset = "0x2719A10", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000600")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60005FD")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000BF")]
	private sealed class <Load>d__28 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40003D3")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40003D4")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40003D5")]
		public TXEAEPlayer <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40003D6")]
		public string assetLabel; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40003D7")]
		public string locale; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40003D8")]
		public List<String> markerTags; //Field offset: 0x38

		[Token(Token = "0x170001D9")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000605")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001DA")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000607")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000602")]
		public <Load>d__28(int <>1__state) { }

		[Address(RVA = "0x271C280", Offset = "0x271B680", Length = "0x33C")]
		[Token(Token = "0x6000604")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000605")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000607")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x271C5C0", Offset = "0x271B9C0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000606")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000603")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000C0")]
	private sealed class <Setup>d__29 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40003D9")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40003DA")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40003DB")]
		public TXEAEPlayer <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40003DC")]
		public List<String> markerTags; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40003DD")]
		public Action<AEAsAnimationRoot, Dictionary`2<String, List`1<MarkerData>>> onReady; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40003DE")]
		public AEData data; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40003DF")]
		public IAETextureAccessor textureAccessor; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40003E0")]
		public IAEAudioAccessor audioAccessor; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40003E1")]
		public IAECompositionFilter compositionFilter; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40003E2")]
		public IAELayerFilter layerFilter; //Field offset: 0x58

		[Token(Token = "0x170001DB")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600060B")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001DC")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600060D")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000608")]
		public <Setup>d__29(int <>1__state) { }

		[Address(RVA = "0x271ED10", Offset = "0x271E110", Length = "0x21A")]
		[Token(Token = "0x600060A")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600060B")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600060D")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x271EF30", Offset = "0x271E330", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600060C")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000609")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x20000B3")]
	internal class AECompositionFilter : IAECompositionFilter
	{
		[CompilerGenerated]
		[Token(Token = "0x20000B4")]
		private sealed class <>c
		{
			[Token(Token = "0x40003B4")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x40003B5")]
			public static Converter<String, String> <>9__1_0; //Field offset: 0x8

			[Address(RVA = "0x271FE00", Offset = "0x271F200", Length = "0x67")]
			[Token(Token = "0x60005DE")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60005DF")]
			public <>c() { }

			[Address(RVA = "0x271F870", Offset = "0x271EC70", Length = "0x1F")]
			[Token(Token = "0x60005E0")]
			internal string <.ctor>b__1_0(string e) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x20000B5")]
		private sealed class <>c__DisplayClass1_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40003B6")]
			public string locale; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60005E1")]
			public <>c__DisplayClass1_0() { }

			[Address(RVA = "0x271F8E0", Offset = "0x271ECE0", Length = "0x12")]
			[Token(Token = "0x60005E2")]
			internal bool <.ctor>b__1(string e) { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40003B3")]
		private IList<String> _disableLocales; //Field offset: 0x10

		[Address(RVA = "0x27087E0", Offset = "0x2707BE0", Length = "0x238")]
		[Token(Token = "0x60005DC")]
		public AECompositionFilter(string locale) { }

		[Address(RVA = "0x2708720", Offset = "0x2707B20", Length = "0xB5")]
		[Token(Token = "0x60005DD")]
		public override void Filter(ref CompositionData data) { }

	}

	[Token(Token = "0x20000B6")]
	internal class AELayerFilter : IAELayerFilter
	{
		[CompilerGenerated]
		[Token(Token = "0x20000B7")]
		private sealed class <>c
		{
			[Token(Token = "0x40003B8")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x40003B9")]
			public static Converter<String, String> <>9__1_0; //Field offset: 0x8

			[Address(RVA = "0x271FD20", Offset = "0x271F120", Length = "0x67")]
			[Token(Token = "0x60005E5")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60005E6")]
			public <>c() { }

			[Address(RVA = "0x271F870", Offset = "0x271EC70", Length = "0x1F")]
			[Token(Token = "0x60005E7")]
			internal string <.ctor>b__1_0(string e) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x20000B8")]
		private sealed class <>c__DisplayClass1_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40003BA")]
			public string locale; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60005E8")]
			public <>c__DisplayClass1_0() { }

			[Address(RVA = "0x271F8E0", Offset = "0x271ECE0", Length = "0x12")]
			[Token(Token = "0x60005E9")]
			internal bool <.ctor>b__1(string e) { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40003B7")]
		private IList<String> _disableLocales; //Field offset: 0x10

		[Address(RVA = "0x2708AE0", Offset = "0x2707EE0", Length = "0x238")]
		[Token(Token = "0x60005E3")]
		public AELayerFilter(string locale) { }

		[Address(RVA = "0x2708A20", Offset = "0x2707E20", Length = "0xB8")]
		[Token(Token = "0x60005E4")]
		public override void Filter(ref LayerData data) { }

	}

	[Token(Token = "0x20000B0")]
	internal class AudioAccessor : IAEAudioAccessor
	{
		[Token(Token = "0x20000B1")]
		private class BGMPlayer
		{
			[Token(Token = "0x20000B2")]
			private enum Status : int
			{
				NONE = 0,
				PLAY = 1,
				FADE = 2,
			}

			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40003A9")]
			private Status _status; //Field offset: 0x10
			[FieldOffset(Offset = "0x14")]
			[Token(Token = "0x40003AA")]
			private BGM _id; //Field offset: 0x14
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x40003AB")]
			private int _channel; //Field offset: 0x18
			[FieldOffset(Offset = "0x1C")]
			[Token(Token = "0x40003AC")]
			private float _volume; //Field offset: 0x1C
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x40003AD")]
			private float _fadeTime; //Field offset: 0x20
			[FieldOffset(Offset = "0x24")]
			[Token(Token = "0x40003AE")]
			private float _fadeProgress; //Field offset: 0x24

			[Address(RVA = "0x270B370", Offset = "0x270A770", Length = "0x6D")]
			[Token(Token = "0x60005DB")]
			public BGMPlayer() { }

			[Address(RVA = "0x270AD70", Offset = "0x270A170", Length = "0x2FA")]
			[Token(Token = "0x60005DA")]
			public string DebugPrint() { }

			[Address(RVA = "0x270B070", Offset = "0x270A470", Length = "0x18")]
			[Token(Token = "0x60005D8")]
			public void FadeOut(float time) { }

			[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
			[Token(Token = "0x60005D3")]
			public BGM Id() { }

			[Address(RVA = "0xF54050", Offset = "0xF53450", Length = "0x8")]
			[Token(Token = "0x60005D2")]
			public bool IsPlay() { }

			[Address(RVA = "0x270B090", Offset = "0x270A490", Length = "0xD0")]
			[Token(Token = "0x60005D4")]
			public bool Play(BGM id, float volume, bool force) { }

			[Address(RVA = "0x270B160", Offset = "0x270A560", Length = "0x16")]
			[Token(Token = "0x60005D6")]
			private void Reset() { }

			[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
			[Token(Token = "0x60005D1")]
			public void SetChannel(int channel) { }

			[Address(RVA = "0x270B180", Offset = "0x270A580", Length = "0x78")]
			[Token(Token = "0x60005D5")]
			public void Stop(bool forceStop = false) { }

			[Address(RVA = "0x270B200", Offset = "0x270A600", Length = "0xDD")]
			[Token(Token = "0x60005D9")]
			public void Update(float deltaTime) { }

			[Address(RVA = "0x270B2E0", Offset = "0x270A6E0", Length = "0x8C")]
			[Token(Token = "0x60005D7")]
			public bool Volume(BGM id, float volume) { }

		}

		[Token(Token = "0x40003A4")]
		private static readonly int INVALID_CH; //Field offset: 0x0
		[Token(Token = "0x40003A5")]
		private static readonly int BGM_CHANNEL; //Field offset: 0x4
		[Token(Token = "0x40003A6")]
		private static readonly float BGM_FADEOUT_TIME; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40003A7")]
		private List<AudioPlayer> _players; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40003A8")]
		private List<BGMPlayer> _bgmChannel; //Field offset: 0x18

		[Address(RVA = "0x270A810", Offset = "0x2709C10", Length = "0x93")]
		[Token(Token = "0x60005D0")]
		private static AudioAccessor() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60005CF")]
		public AudioAccessor() { }

		[Address(RVA = "0x27093F0", Offset = "0x27087F0", Length = "0x2DE")]
		[Token(Token = "0x60005CC")]
		public void AutoStopBGM() { }

		[Address(RVA = "0x27096D0", Offset = "0x2708AD0", Length = "0x1B6")]
		[Token(Token = "0x60005CB")]
		public void Clear() { }

		[Address(RVA = "0x2709890", Offset = "0x2708C90", Length = "0x34D")]
		[Token(Token = "0x60005CE")]
		public string DebugPrint() { }

		[Address(RVA = "0x2709BE0", Offset = "0x2708FE0", Length = "0xF2")]
		[Token(Token = "0x60005C7")]
		public override IAEAudioPlayer GetPlayer() { }

		[Address(RVA = "0x2709CE0", Offset = "0x27090E0", Length = "0x207")]
		[Token(Token = "0x60005C5")]
		public void Initialize() { }

		[Address(RVA = "0x2709EF0", Offset = "0x27092F0", Length = "0x376")]
		[Token(Token = "0x60005C8")]
		public void PlayBGM(BGM bgmId, float volume) { }

		[Address(RVA = "0x270A410", Offset = "0x2709810", Length = "0x1AE")]
		[Token(Token = "0x60005C9")]
		public void Stop(bool stopBgm, bool forceStop = false) { }

		[Address(RVA = "0x270A270", Offset = "0x2709670", Length = "0x197")]
		[Token(Token = "0x60005CA")]
		public void StopBGM(bool forceStop = false) { }

		[Address(RVA = "0x270A5C0", Offset = "0x27099C0", Length = "0x43")]
		[Token(Token = "0x60005C6")]
		public void Terminate() { }

		[Address(RVA = "0x270A610", Offset = "0x2709A10", Length = "0x1FA")]
		[Token(Token = "0x60005CD")]
		public void Update(float deltaTime) { }

	}

	[Token(Token = "0x20000AF")]
	internal class AudioPlayer : IAEAudioPlayer
	{
		[Token(Token = "0x400039D")]
		public const int INVALID_CH = -1; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400039E")]
		private int _soundCh; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x400039F")]
		private ID _seId; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40003A0")]
		private BGM _bgmId; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40003A1")]
		private AudioAccessor _accessor; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40003A2")]
		private float _volume; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x40003A3")]
		private bool _playingBgm; //Field offset: 0x2C

		[Address(RVA = "0x270AD20", Offset = "0x270A120", Length = "0x40")]
		[Token(Token = "0x60005BE")]
		public AudioPlayer(AudioAccessor accessor) { }

		[Address(RVA = "0x270A8B0", Offset = "0x2709CB0", Length = "0xD7")]
		[Token(Token = "0x60005C3")]
		public string DebugPrint() { }

		[Address(RVA = "0x270A990", Offset = "0x2709D90", Length = "0x6A")]
		[Token(Token = "0x60005C4")]
		public Sprite GetSprite(AssetReferenceT<Sprite> reference) { }

		[Address(RVA = "0x270AA00", Offset = "0x2709E00", Length = "0x1D9")]
		[Token(Token = "0x60005BF")]
		public override void Initialize(string name) { }

		[Address(RVA = "0x270AD60", Offset = "0x270A160", Length = "0xD")]
		[Token(Token = "0x60005C2")]
		public bool isPlayingBGM(BGM bgmId) { }

		[Address(RVA = "0x270ABE0", Offset = "0x2709FE0", Length = "0xC4")]
		[Token(Token = "0x60005C0")]
		public override void Play(float volume) { }

		[Address(RVA = "0x270ACB0", Offset = "0x270A0B0", Length = "0x67")]
		[Token(Token = "0x60005C1")]
		public override void Stop() { }

	}

	[Token(Token = "0x20000BA")]
	internal sealed class MarkerCallback : MulticastDelegate
	{

		[Address(RVA = "0x5BC6F0", Offset = "0x5BBAF0", Length = "0x124")]
		[Token(Token = "0x60005EA")]
		public MarkerCallback(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6A0", Offset = "0x5BBAA0", Length = "0x21")]
		[Token(Token = "0x60005EC")]
		public override IAsyncResult BeginInvoke(MarkerData marker, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x60005ED")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x60005EB")]
		public override void Invoke(MarkerData marker) { }

	}

	[Token(Token = "0x20000B9")]
	internal enum Status : int
	{
		None = 0,
		Initialized = 1,
		Loading = 2,
		Ready = 3,
		Playing = 4,
		Pause = 5,
		Stop = 6,
		Error = 7,
	}

	[Token(Token = "0x20000AB")]
	internal class TextureAccessor : IAETextureAccessor
	{
		[CompilerGenerated]
		[Token(Token = "0x20000AC")]
		private sealed class <Load>d__5 : IEnumerator<Object>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000392")]
			private int <>1__state; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000393")]
			private object <>2__current; //Field offset: 0x18
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000394")]
			public TextureAccessor <>4__this; //Field offset: 0x20
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x4000395")]
			public string addressableLabel; //Field offset: 0x28
			[FieldOffset(Offset = "0x30")]
			[Token(Token = "0x4000396")]
			public string locale; //Field offset: 0x30

			[Token(Token = "0x170001CF")]
			private override object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x60005AF")]
				private get { } //Length: 5
			}

			[Token(Token = "0x170001D0")]
			private override object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x60005B1")]
				private get { } //Length: 5
			}

			[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
			[DebuggerHidden]
			[Token(Token = "0x60005AC")]
			public <Load>d__5(int <>1__state) { }

			[Address(RVA = "0x271D7D0", Offset = "0x271CBD0", Length = "0x16D")]
			[Token(Token = "0x60005AE")]
			private override bool MoveNext() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60005AF")]
			private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60005B1")]
			private override object System.Collections.IEnumerator.get_Current() { }

			[Address(RVA = "0x271D940", Offset = "0x271CD40", Length = "0x3E")]
			[DebuggerHidden]
			[Token(Token = "0x60005B0")]
			private override void System.Collections.IEnumerator.Reset() { }

			[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
			[DebuggerHidden]
			[Token(Token = "0x60005AD")]
			private override void System.IDisposable.Dispose() { }

		}

		[CompilerGenerated]
		[Token(Token = "0x20000AD")]
		private sealed class <LoadAdditionalLocale>d__6 : IEnumerator<Object>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000397")]
			private int <>1__state; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000398")]
			private object <>2__current; //Field offset: 0x18
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000399")]
			public TextureAccessor <>4__this; //Field offset: 0x20
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x400039A")]
			public string locale; //Field offset: 0x28

			[Token(Token = "0x170001D1")]
			private override object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x60005B5")]
				private get { } //Length: 5
			}

			[Token(Token = "0x170001D2")]
			private override object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x60005B7")]
				private get { } //Length: 5
			}

			[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
			[DebuggerHidden]
			[Token(Token = "0x60005B2")]
			public <LoadAdditionalLocale>d__6(int <>1__state) { }

			[Address(RVA = "0x271ACB0", Offset = "0x271A0B0", Length = "0x12A")]
			[Token(Token = "0x60005B4")]
			private override bool MoveNext() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60005B5")]
			private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60005B7")]
			private override object System.Collections.IEnumerator.get_Current() { }

			[Address(RVA = "0x271ADE0", Offset = "0x271A1E0", Length = "0x3E")]
			[DebuggerHidden]
			[Token(Token = "0x60005B6")]
			private override void System.Collections.IEnumerator.Reset() { }

			[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
			[DebuggerHidden]
			[Token(Token = "0x60005B3")]
			private override void System.IDisposable.Dispose() { }

		}

		[CompilerGenerated]
		[Token(Token = "0x20000AE")]
		private sealed class <LoadFallback>d__7 : IEnumerator<Object>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400039B")]
			private int <>1__state; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x400039C")]
			private object <>2__current; //Field offset: 0x18

			[Token(Token = "0x170001D3")]
			private override object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x60005BB")]
				private get { } //Length: 5
			}

			[Token(Token = "0x170001D4")]
			private override object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x60005BD")]
				private get { } //Length: 5
			}

			[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
			[DebuggerHidden]
			[Token(Token = "0x60005B8")]
			public <LoadFallback>d__7(int <>1__state) { }

			[Address(RVA = "0x1B7BED0", Offset = "0x1B7B2D0", Length = "0x10")]
			[Token(Token = "0x60005BA")]
			private override bool MoveNext() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60005BB")]
			private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60005BD")]
			private override object System.Collections.IEnumerator.get_Current() { }

			[Address(RVA = "0x271B070", Offset = "0x271A470", Length = "0x3E")]
			[DebuggerHidden]
			[Token(Token = "0x60005BC")]
			private override void System.Collections.IEnumerator.Reset() { }

			[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
			[DebuggerHidden]
			[Token(Token = "0x60005B9")]
			private override void System.IDisposable.Dispose() { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400038F")]
		private string _label; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000390")]
		private string _locale; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000391")]
		private IList<SpriteAtlas> _spriteAtlases; //Field offset: 0x20

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60005AB")]
		public TextureAccessor() { }

		[Address(RVA = "0x2718D80", Offset = "0x2718180", Length = "0x250")]
		[Token(Token = "0x60005AA")]
		public override Sprite GetSprite(string name) { }

		[Address(RVA = "0xAFF7C0", Offset = "0xAFEBC0", Length = "0x47")]
		[Token(Token = "0x60005A4")]
		public void Initialize() { }

		[Address(RVA = "0x27190C0", Offset = "0x27184C0", Length = "0xA1")]
		[IteratorStateMachine(typeof(<Load>d__5))]
		[Token(Token = "0x60005A6")]
		public IEnumerator Load(string addressableLabel, string locale) { }

		[Address(RVA = "0x2718FE0", Offset = "0x27183E0", Length = "0x84")]
		[IteratorStateMachine(typeof(<LoadAdditionalLocale>d__6))]
		[Token(Token = "0x60005A7")]
		public IEnumerator LoadAdditionalLocale(string locale) { }

		[Address(RVA = "0x2719070", Offset = "0x2718470", Length = "0x4B")]
		[IteratorStateMachine(typeof(<LoadFallback>d__7))]
		[Token(Token = "0x60005A8")]
		public IEnumerator LoadFallback(string addressableLabel) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60005A9")]
		public void ReleaseFallback(string addressableLabel) { }

		[Address(RVA = "0xAFF7C0", Offset = "0xAFEBC0", Length = "0x47")]
		[Token(Token = "0x60005A5")]
		public void Terminate() { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000381")]
	private TextReflector _textReflector; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000382")]
	private Status _state; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000383")]
	private GameObject _aeObject; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000384")]
	private AEData _data; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000385")]
	private AEAsAnimationRoot _aeRoot; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000386")]
	private TextureAccessor _textures; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000387")]
	private AudioAccessor _audio; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000388")]
	private AECompositionFilter _compositionFilter; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000389")]
	private AELayerFilter _layerFilter; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400038A")]
	private string _assetLabel; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400038B")]
	private string _locale; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400038C")]
	private bool _isReady; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400038D")]
	private Dictionary<String, List`1<MarkerData>> _markers; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400038E")]
	private MarkerCallback _markerCallback; //Field offset: 0x88

	[Token(Token = "0x170001CE")]
	public MarkerCallback markerCallback
	{
		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[Token(Token = "0x600058B")]
		 get { } //Length: 8
		[Address(RVA = "0xE26DF0", Offset = "0xE261F0", Length = "0x13")]
		[Token(Token = "0x600058C")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170001CD")]
	public Status State
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[Token(Token = "0x600058A")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x60005A1")]
	public TXEAEPlayer() { }

	[Address(RVA = "0x2700250", Offset = "0x26FF650", Length = "0x16E")]
	[CompilerGenerated]
	[Token(Token = "0x60005A2")]
	internal static void <Initialize>g__updateFontColor|26_0(UITextMeshPro text, Color color) { }

	[Address(RVA = "0x27003C0", Offset = "0x26FF7C0", Length = "0x21")]
	[CompilerGenerated]
	[Token(Token = "0x60005A3")]
	private void <UpdateTime>b__32_0(MarkerData marker) { }

	[Address(RVA = "0x26FF1C0", Offset = "0x26FE5C0", Length = "0x6D")]
	[IteratorStateMachine(typeof(<CoroutineWaitForReady>d__43))]
	[Token(Token = "0x600059E")]
	public IEnumerator CoroutineWaitForReady() { }

	[Address(RVA = "0x26FF230", Offset = "0x26FE630", Length = "0x6D")]
	[IteratorStateMachine(typeof(<CoroutineWaitForStop>d__44))]
	[Token(Token = "0x600059F")]
	public IEnumerator CoroutineWaitForStop() { }

	[Address(RVA = "0x26FF2A0", Offset = "0x26FE6A0", Length = "0x84")]
	[Token(Token = "0x60005A0")]
	public float CurrentTime() { }

	[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
	[Token(Token = "0x600058B")]
	public MarkerCallback get_markerCallback() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[Token(Token = "0x600058A")]
	public Status get_State() { }

	[Address(RVA = "0x26FF330", Offset = "0x26FE730", Length = "0x3D")]
	[Token(Token = "0x6000597")]
	public Status GetStatus() { }

	[Address(RVA = "0x26FF370", Offset = "0x26FE770", Length = "0x42B")]
	[Token(Token = "0x600058D")]
	public void Initialize(Transform parent) { }

	[Address(RVA = "0x26FF7A0", Offset = "0x26FEBA0", Length = "0xDF")]
	[Token(Token = "0x600059D")]
	public bool IsOverMarker(string label, int index) { }

	[Address(RVA = "0x26FF880", Offset = "0x26FEC80", Length = "0x1D")]
	[Token(Token = "0x6000599")]
	public void JumpEnd() { }

	[Address(RVA = "0x26FFC80", Offset = "0x26FF080", Length = "0x1E")]
	[Token(Token = "0x600059A")]
	public void JumpMarker(MarkerData marker) { }

	[Address(RVA = "0x26FF8A0", Offset = "0x26FECA0", Length = "0x3DB")]
	[Token(Token = "0x600059B")]
	public bool JumpMarker(string label, int offset) { }

	[Address(RVA = "0x26FFCA0", Offset = "0x26FF0A0", Length = "0x1D")]
	[Token(Token = "0x6000598")]
	public void JumpStart() { }

	[Address(RVA = "0x26FFCC0", Offset = "0x26FF0C0", Length = "0xC6")]
	[IteratorStateMachine(typeof(<Load>d__28))]
	[Token(Token = "0x600058F")]
	public IEnumerator Load(string assetLabel, string locale, List<String> markerTags = null) { }

	[Address(RVA = "0x26FFD90", Offset = "0x26FF190", Length = "0x190")]
	[Token(Token = "0x600059C")]
	public bool NextMarker(string label) { }

	[Address(RVA = "0x27005E0", Offset = "0x26FF9E0", Length = "0x6E9")]
	[Token(Token = "0x6000591")]
	private void onLoadReady(List<String> markerTags = null, Action<AEAsAnimationRoot, Dictionary`2<String, List`1<MarkerData>>> onReady = null) { }

	[Address(RVA = "0x26FFF90", Offset = "0x26FF390", Length = "0x31")]
	[Token(Token = "0x6000596")]
	public void Play() { }

	[Address(RVA = "0x26FFF30", Offset = "0x26FF330", Length = "0x5A")]
	[Token(Token = "0x6000594")]
	public bool PlayFromStart(bool isLoop = false) { }

	[Address(RVA = "0xE26DF0", Offset = "0xE261F0", Length = "0x13")]
	[Token(Token = "0x600058C")]
	public void set_markerCallback(MarkerCallback value) { }

	[Address(RVA = "0x26FFFD0", Offset = "0x26FF3D0", Length = "0x112")]
	[IteratorStateMachine(typeof(<Setup>d__29))]
	[Token(Token = "0x6000590")]
	public IEnumerator Setup(AEData data, IAETextureAccessor textureAccessor, IAEAudioAccessor audioAccessor, IAECompositionFilter compositionFilter, IAELayerFilter layerFilter, List<String> markerTags, Action<AEAsAnimationRoot, Dictionary`2<String, List`1<MarkerData>>> onReady = null) { }

	[Address(RVA = "0x27000F0", Offset = "0x26FF4F0", Length = "0x31")]
	[Token(Token = "0x6000595")]
	public void Stop() { }

	[Address(RVA = "0x2700130", Offset = "0x26FF530", Length = "0x119")]
	[Token(Token = "0x600058E")]
	public void Terminate() { }

	[Address(RVA = "0x27004B0", Offset = "0x26FF8B0", Length = "0x12B")]
	[Token(Token = "0x6000592")]
	public void Update() { }

	[Address(RVA = "0x27003F0", Offset = "0x26FF7F0", Length = "0xB2")]
	[Token(Token = "0x6000593")]
	public bool UpdateTime() { }

}

