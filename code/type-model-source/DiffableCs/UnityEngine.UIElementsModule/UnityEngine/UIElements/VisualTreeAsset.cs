namespace UnityEngine.UIElements;

[HelpURL("UIE-VisualTree-landing")]
[Token(Token = "0x2000521")]
public class VisualTreeAsset : ScriptableObject
{
	[CompilerGenerated]
	[Token(Token = "0x2000527")]
	private sealed class <>c__DisplayClass69_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40010EC")]
		public VisualElementAsset childVea; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600263B")]
		public <>c__DisplayClass69_0() { }

		[Address(RVA = "0x32BB180", Offset = "0x32BA580", Length = "0x20")]
		[Token(Token = "0x600263C")]
		internal bool <CloneSetupRecursively>b__0(SlotUsageEntry u) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000528")]
	private struct <>c__DisplayClass80_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40010ED")]
		public VisualElementAsset asset; //Field offset: 0x0

	}

	[CompilerGenerated]
	[Token(Token = "0x2000529")]
	private sealed class <DepthFirstTraversal>d__88 : IEnumerable<UxmlAsset>, IEnumerable, IEnumerator<UxmlAsset>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40010EE")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40010EF")]
		private UxmlAsset <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40010F0")]
		private int <>l__initialThreadId; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40010F1")]
		private UxmlAsset asset; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40010F2")]
		public UxmlAsset <>3__asset; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40010F3")]
		public VisualTreeAsset <>4__this; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40010F4")]
		private int <i>5__1; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40010F5")]
		private IEnumerator<UxmlAsset> <>s__2; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40010F6")]
		private UxmlAsset <child>5__3; //Field offset: 0x50

		[Token(Token = "0x170009FB")]
		private override UxmlAsset System.Collections.Generic.IEnumerator<UnityEngine.UIElements.UxmlAsset>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6002641")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170009FC")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6002643")]
			private get { } //Length: 5
		}

		[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x600263D")]
		public <DepthFirstTraversal>d__88(int <>1__state) { }

		[Address(RVA = "0x32BA7D0", Offset = "0x32B9BD0", Length = "0x50")]
		[Token(Token = "0x6002640")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x32BA310", Offset = "0x32B9710", Length = "0x331")]
		[Token(Token = "0x600263F")]
		private override bool MoveNext() { }

		[Address(RVA = "0x32BA650", Offset = "0x32B9A50", Length = "0xAD")]
		[DebuggerHidden]
		[Token(Token = "0x6002644")]
		private override IEnumerator<UxmlAsset> System.Collections.Generic.IEnumerable<UnityEngine.UIElements.UxmlAsset>.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6002641")]
		private override UxmlAsset System.Collections.Generic.IEnumerator<UnityEngine.UIElements.UxmlAsset>.get_Current() { }

		[Address(RVA = "0x32BA650", Offset = "0x32B9A50", Length = "0xAD")]
		[DebuggerHidden]
		[Token(Token = "0x6002645")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6002643")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x32BA700", Offset = "0x32B9B00", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6002642")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x32BA740", Offset = "0x32B9B40", Length = "0x8C")]
		[DebuggerHidden]
		[Token(Token = "0x600263E")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200052A")]
	private sealed class <DepthFirstTraversalOfType>d__87 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40010F7")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40010F8")]
		private T <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40010F9")]
		private int <>l__initialThreadId; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40010FA")]
		public VisualTreeAsset <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40010FB")]
		private IEnumerable<UxmlAsset> <elements>5__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40010FC")]
		private IEnumerator<UxmlAsset> <>s__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40010FD")]
		private UxmlAsset <element>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40010FE")]
		private T <tElement>5__4; //Field offset: 0x0

		[Token(Token = "0x170009FD")]
		private override T System.Collections.Generic.IEnumerator<T>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600264A")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170009FE")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600264C")]
			private get { } //Length: 5
		}

		[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x6002646")]
		public <DepthFirstTraversalOfType>d__87`1(int <>1__state) { }

		[Address(RVA = "0x1155010", Offset = "0x1154410", Length = "0x50")]
		[Token(Token = "0x6002649")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x1154230", Offset = "0x1153630", Length = "0x330")]
		[Token(Token = "0x6002648")]
		private override bool MoveNext() { }

		[Address(RVA = "0xA66280", Offset = "0xA65680", Length = "0xAC")]
		[DebuggerHidden]
		[Token(Token = "0x600264D")]
		private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600264A")]
		private override T System.Collections.Generic.IEnumerator<T>.get_Current() { }

		[Address(RVA = "0x1154DC0", Offset = "0x11541C0", Length = "0xB8")]
		[DebuggerHidden]
		[Token(Token = "0x600264E")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600264C")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xA663F0", Offset = "0xA657F0", Length = "0x39")]
		[DebuggerHidden]
		[Token(Token = "0x600264B")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x1154E80", Offset = "0x1154280", Length = "0x9B")]
		[DebuggerHidden]
		[Token(Token = "0x6002647")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200052B")]
	private sealed class <get_stylesheets>d__40 : IEnumerable<StyleSheet>, IEnumerable, IEnumerator<StyleSheet>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40010FF")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001100")]
		private StyleSheet <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001101")]
		private int <>l__initialThreadId; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4001102")]
		public VisualTreeAsset <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4001103")]
		private PooledObject<HashSet`1<StyleSheet>> <setHandle>5__1; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4001104")]
		private HashSet<StyleSheet> <sent>5__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4001105")]
		private PooledObject<List`1<UxmlAsset>> <_>5__3; //Field offset: 0x48
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4001106")]
		private List<UxmlAsset> <list>5__4; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4001107")]
		private Enumerator<UxmlAsset> <>s__5; //Field offset: 0x60
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4001108")]
		private UxmlAsset <asset>5__6; //Field offset: 0x78
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4001109")]
		private VisualElementAsset <vea>5__7; //Field offset: 0x80
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x400110A")]
		private Enumerator<StyleSheet> <>s__8; //Field offset: 0x88
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x400110B")]
		private StyleSheet <stylesheet>5__9; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x400110C")]
		private Enumerator<String> <>s__10; //Field offset: 0xA8
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x400110D")]
		private string <stylesheetPath>5__11; //Field offset: 0xC0
		[FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x400110E")]
		private StyleSheet <stylesheet>5__12; //Field offset: 0xC8

		[Token(Token = "0x170009FF")]
		private override StyleSheet System.Collections.Generic.IEnumerator<UnityEngine.UIElements.StyleSheet>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6002657")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000A00")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6002659")]
			private get { } //Length: 5
		}

		[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x600264F")]
		public <get_stylesheets>d__40(int <>1__state) { }

		[Address(RVA = "0x32BC640", Offset = "0x32BBA40", Length = "0x41")]
		[Token(Token = "0x6002652")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x32BC690", Offset = "0x32BBA90", Length = "0x41")]
		[Token(Token = "0x6002653")]
		private void <>m__Finally2() { }

		[Address(RVA = "0x32BC6E0", Offset = "0x32BBAE0", Length = "0x41")]
		[Token(Token = "0x6002654")]
		private void <>m__Finally3() { }

		[Address(RVA = "0x32BC730", Offset = "0x32BBB30", Length = "0x44")]
		[Token(Token = "0x6002655")]
		private void <>m__Finally4() { }

		[Address(RVA = "0x32BC780", Offset = "0x32BBB80", Length = "0x44")]
		[Token(Token = "0x6002656")]
		private void <>m__Finally5() { }

		[Address(RVA = "0x32BB840", Offset = "0x32BAC40", Length = "0xA55")]
		[Token(Token = "0x6002651")]
		private override bool MoveNext() { }

		[Address(RVA = "0x32BC2A0", Offset = "0x32BB6A0", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x600265A")]
		private override IEnumerator<StyleSheet> System.Collections.Generic.IEnumerable<UnityEngine.UIElements.StyleSheet>.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6002657")]
		private override StyleSheet System.Collections.Generic.IEnumerator<UnityEngine.UIElements.StyleSheet>.get_Current() { }

		[Address(RVA = "0x32BC2A0", Offset = "0x32BB6A0", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x600265B")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6002659")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x32BC340", Offset = "0x32BB740", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6002658")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x32BC380", Offset = "0x32BB780", Length = "0x2B6")]
		[DebuggerHidden]
		[Token(Token = "0x6002650")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200052C")]
	private sealed class <get_templateDependencies>d__30 : IEnumerable<VisualTreeAsset>, IEnumerable, IEnumerator<VisualTreeAsset>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400110F")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001110")]
		private VisualTreeAsset <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001111")]
		private int <>l__initialThreadId; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4001112")]
		public VisualTreeAsset <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4001113")]
		private HashSet<VisualTreeAsset> <sent>5__1; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4001114")]
		private Enumerator<UsingEntry> <>s__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4001115")]
		private UsingEntry <entry>5__3; //Field offset: 0x60
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4001116")]
		private VisualTreeAsset <vta>5__4; //Field offset: 0x78

		[Token(Token = "0x17000A01")]
		private override VisualTreeAsset System.Collections.Generic.IEnumerator<UnityEngine.UIElements.VisualTreeAsset>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6002660")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000A02")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6002662")]
			private get { } //Length: 5
		}

		[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x600265C")]
		public <get_templateDependencies>d__30(int <>1__state) { }

		[Address(RVA = "0x32BCF60", Offset = "0x32BC360", Length = "0x41")]
		[Token(Token = "0x600265F")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x32BC7D0", Offset = "0x32BBBD0", Length = "0x612")]
		[Token(Token = "0x600265E")]
		private override bool MoveNext() { }

		[Address(RVA = "0x32BCDF0", Offset = "0x32BC1F0", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x6002663")]
		private override IEnumerator<VisualTreeAsset> System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualTreeAsset>.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6002660")]
		private override VisualTreeAsset System.Collections.Generic.IEnumerator<UnityEngine.UIElements.VisualTreeAsset>.get_Current() { }

		[Address(RVA = "0x32BCDF0", Offset = "0x32BC1F0", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x6002664")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6002662")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x32BCE90", Offset = "0x32BC290", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6002661")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x32BCED0", Offset = "0x32BC2D0", Length = "0x85")]
		[DebuggerHidden]
		[Token(Token = "0x600265D")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000526")]
	private struct AssetEntry
	{
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[Token(Token = "0x40010E7")]
		private string m_Path; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		[Token(Token = "0x40010E8")]
		private string m_TypeFullName; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Token(Token = "0x40010E9")]
		private LazyLoadReference<Object> m_AssetReference; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		[Token(Token = "0x40010EA")]
		private int m_InstanceID; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40010EB")]
		private Type m_CachedType; //Field offset: 0x18

		[Token(Token = "0x170009FA")]
		public object asset
		{
			[Address(RVA = "0x32B8050", Offset = "0x32B7450", Length = "0x63")]
			[Token(Token = "0x6002639")]
			 get { } //Length: 99
		}

		[Token(Token = "0x170009F9")]
		public string path
		{
			[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
			[Token(Token = "0x6002638")]
			 get { } //Length: 4
		}

		[Token(Token = "0x170009F8")]
		public Type type
		{
			[Address(RVA = "0x32B80C0", Offset = "0x32B74C0", Length = "0x8E")]
			[Token(Token = "0x6002637")]
			 get { } //Length: 142
		}

		[Address(RVA = "0x32B7F80", Offset = "0x32B7380", Length = "0xC7")]
		[Token(Token = "0x600263A")]
		public AssetEntry(string path, Type type, object asset) { }

		[Address(RVA = "0x32B8050", Offset = "0x32B7450", Length = "0x63")]
		[Token(Token = "0x6002639")]
		public object get_asset() { }

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x6002638")]
		public string get_path() { }

		[Address(RVA = "0x32B80C0", Offset = "0x32B74C0", Length = "0x8E")]
		[Token(Token = "0x6002637")]
		public Type get_type() { }

	}

	[Token(Token = "0x2000524")]
	public struct SlotDefinition
	{
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[Token(Token = "0x40010E3")]
		public string name; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		[Token(Token = "0x40010E4")]
		public int insertionPointId; //Field offset: 0x8

	}

	[Token(Token = "0x2000525")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	public struct SlotUsageEntry
	{
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[Token(Token = "0x40010E5")]
		public string slotName; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		[Token(Token = "0x40010E6")]
		public int assetId; //Field offset: 0x8

	}

	[Token(Token = "0x2000522")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	public struct UsingEntry
	{
		[Token(Token = "0x40010DF")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal static readonly IComparer<UsingEntry> comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[Token(Token = "0x40010E0")]
		public string alias; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		[Token(Token = "0x40010E1")]
		public string path; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Token(Token = "0x40010E2")]
		public VisualTreeAsset asset; //Field offset: 0x10

		[Address(RVA = "0x32C1600", Offset = "0x32C0A00", Length = "0x73")]
		[Token(Token = "0x6002634")]
		private static UsingEntry() { }

		[Address(RVA = "0x32C16D0", Offset = "0x32C0AD0", Length = "0x45")]
		[Token(Token = "0x6002633")]
		public UsingEntry(string alias, VisualTreeAsset asset) { }

		[Address(RVA = "0x32C1680", Offset = "0x32C0A80", Length = "0x45")]
		[Token(Token = "0x6002632")]
		public UsingEntry(string alias, string path) { }

	}

	[Token(Token = "0x2000523")]
	private class UsingEntryComparer : IComparer<UsingEntry>
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6002636")]
		public UsingEntryComparer() { }

		[Address(RVA = "0x32C15D0", Offset = "0x32C09D0", Length = "0x21")]
		[Token(Token = "0x6002635")]
		public override int Compare(UsingEntry x, UsingEntry y) { }

	}

	[Token(Token = "0x40010D0")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal static string NoRegisteredFactoryErrorMessage; //Field offset: 0x0
	[Token(Token = "0x40010D1")]
	internal const string TemplateAliasExistsError = "VisualTreeAsset: could not register a template alias for asset `{0}`, alias is already defined for asset '{1}'"; //Field offset: 0x0
	[Token(Token = "0x40010D6")]
	private static readonly Dictionary<String, VisualElement> s_TemporarySlotInsertionPoints; //Field offset: 0x8
	[Token(Token = "0x40010D7")]
	private static readonly List<Int32> s_VeaIdsPath; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40010D2")]
	private bool m_ImportedWithErrors; //Field offset: 0x18
	[FieldOffset(Offset = "0x19")]
	[SerializeField]
	[Token(Token = "0x40010D3")]
	private bool m_HasEditorElements; //Field offset: 0x19
	[FieldOffset(Offset = "0x1A")]
	[SerializeField]
	[Token(Token = "0x40010D4")]
	private bool m_HasUpdatedUrls; //Field offset: 0x1A
	[FieldOffset(Offset = "0x1B")]
	[SerializeField]
	[Token(Token = "0x40010D5")]
	private bool m_ImportedWithWarnings; //Field offset: 0x1B
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40010D8")]
	private List<UsingEntry> m_Usings; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40010D9")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal StyleSheet inlineSheet; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeReference]
	[Token(Token = "0x40010DA")]
	private VisualElementAsset m_VisualTree; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40010DB")]
	private List<AssetEntry> m_AssetEntries; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x40010DC")]
	private List<SlotDefinition> m_Slots; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x40010DD")]
	private int m_ContentContainerId; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Token(Token = "0x40010DE")]
	private int m_ContentHash; //Field offset: 0x4C

	[Token(Token = "0x170009F6")]
	internal int contentContainerId
	{
		[Address(RVA = "0x2F98AE0", Offset = "0x2F97EE0", Length = "0x6")]
		[Token(Token = "0x600260B")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 6
		[Address(RVA = "0xE0D7D0", Offset = "0xE0CBD0", Length = "0x4")]
		[Token(Token = "0x600260C")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170009F7")]
	public int contentHash
	{
		[Address(RVA = "0x2F91150", Offset = "0x2F90550", Length = "0x6")]
		[Token(Token = "0x6002622")]
		 get { } //Length: 6
		[Address(RVA = "0xFE2A70", Offset = "0xFE1E70", Length = "0x4")]
		[Token(Token = "0x6002623")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170009ED")]
	internal bool hasEditorElements
	{
		[Address(RVA = "0x2F8BC90", Offset = "0x2F8B090", Length = "0x7")]
		[Token(Token = "0x60025F0")]
		internal get { } //Length: 7
		[Address(RVA = "0x21BAC10", Offset = "0x21BA010", Length = "0x4")]
		[Token(Token = "0x60025F1")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170009EC")]
	public internal bool importedWithErrors
	{
		[Address(RVA = "0x2F8BCB0", Offset = "0x2F8B0B0", Length = "0x7")]
		[Token(Token = "0x60025EE")]
		 get { } //Length: 7
		[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
		[Token(Token = "0x60025EF")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170009EF")]
	public internal bool importedWithWarnings
	{
		[Address(RVA = "0x2F98AF0", Offset = "0x2F97EF0", Length = "0x7")]
		[Token(Token = "0x60025F4")]
		 get { } //Length: 7
		[Address(RVA = "0x29EA840", Offset = "0x29E9C40", Length = "0x4")]
		[Token(Token = "0x60025F5")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170009EE")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal bool importerWithUpdatedUrls
	{
		[Address(RVA = "0x2F8BCA0", Offset = "0x2F8B0A0", Length = "0x7")]
		[Token(Token = "0x60025F2")]
		internal get { } //Length: 7
		[Address(RVA = "0x21BAC00", Offset = "0x21BA000", Length = "0x4")]
		[Token(Token = "0x60025F3")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170009F5")]
	internal List<SlotDefinition> slots
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x600260A")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170009F4")]
	public IEnumerable<StyleSheet> stylesheets
	{
		[Address(RVA = "0x32D3E40", Offset = "0x32D3240", Length = "0x71")]
		[IteratorStateMachine(typeof(<get_stylesheets>d__40))]
		[Token(Token = "0x60025FD")]
		 get { } //Length: 113
	}

	[Token(Token = "0x170009F1")]
	public IEnumerable<VisualTreeAsset> templateDependencies
	{
		[Address(RVA = "0x32D3EC0", Offset = "0x32D32C0", Length = "0x71")]
		[IteratorStateMachine(typeof(<get_templateDependencies>d__30))]
		[Token(Token = "0x60025F8")]
		 get { } //Length: 113
	}

	[Token(Token = "0x170009F0")]
	internal List<UsingEntry> usings
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60025F7")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170009F3")]
	internal VisualElementAsset visualTree
	{
		[Address(RVA = "0x32D3F40", Offset = "0x32D3340", Length = "0x623")]
		[Token(Token = "0x60025FB")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 1571
	}

	[Token(Token = "0x170009F2")]
	internal VisualElementAsset visualTreeNoAlloc
	{
		[Address(RVA = "0x2F94490", Offset = "0x2F93890", Length = "0x7")]
		[Token(Token = "0x60025FA")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 7
	}

	[Address(RVA = "0x32D3C00", Offset = "0x32D3000", Length = "0x129")]
	[Token(Token = "0x6002630")]
	private static VisualTreeAsset() { }

	[Address(RVA = "0x32D3D30", Offset = "0x32D3130", Length = "0x103")]
	[Token(Token = "0x600262F")]
	public VisualTreeAsset() { }

	[Address(RVA = "0x32D3740", Offset = "0x32D2B40", Length = "0x181")]
	[CompilerGenerated]
	[Token(Token = "0x6002631")]
	internal static VisualElement <Create>g__CreateError|80_0(ref <>c__DisplayClass80_0 unnamed_param_0) { }

	[Address(RVA = "0x32CE6B0", Offset = "0x32CDAB0", Length = "0x166")]
	[Token(Token = "0x600262E")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal VisualElementAsset AddElementOfType(VisualElementAsset parent, string fullTypeName) { }

	[Address(RVA = "0x32CE820", Offset = "0x32CDC20", Length = "0xE3")]
	[Token(Token = "0x6002629")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal VisualElementAsset AddElementToDocument(VisualElementAsset vea, VisualElementAsset parent) { }

	[Address(RVA = "0x32CE910", Offset = "0x32CDD10", Length = "0x302")]
	[Token(Token = "0x60025FE")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal UxmlObjectAsset AddUxmlObject(UxmlAsset parent, string fieldUxmlName, string fullTypeName, UxmlNamespaceDefinition xmlNamespace = null) { }

	[Address(RVA = "0x32CEC20", Offset = "0x32CE020", Length = "0x1BF")]
	[Token(Token = "0x6002603")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal bool AssetEntryExists(string path, Type type) { }

	[Address(RVA = "0x32CEDE0", Offset = "0x32CE1E0", Length = "0x81")]
	[Token(Token = "0x6002620")]
	private static void AssignClassListFromAssetToElement(VisualElementAsset asset, VisualElement element) { }

	[Address(RVA = "0x32CEE70", Offset = "0x32CE270", Length = "0x336")]
	[Token(Token = "0x6002621")]
	private static void AssignStyleSheetFromAssetToElement(VisualElementAsset asset, VisualElement element) { }

	[Address(RVA = "0x32CF1B0", Offset = "0x32CE5B0", Length = "0x7")]
	[Token(Token = "0x6002600")]
	private void Awake__Internal() { }

	[Address(RVA = "0x32CF1C0", Offset = "0x32CE5C0", Length = "0xA28")]
	[Token(Token = "0x6002614")]
	private VisualElement CloneSetupRecursively(VisualElementAsset asset, CreationContext context) { }

	[Address(RVA = "0x32CFBF0", Offset = "0x32CEFF0", Length = "0x3D9")]
	[Token(Token = "0x6002613")]
	internal void CloneTree(VisualElement target, CreationContext cc) { }

	[Address(RVA = "0x32D0050", Offset = "0x32CF450", Length = "0x2A0")]
	[Token(Token = "0x6002612")]
	public void CloneTree(VisualElement target, out int firstElementIndex, out int elementAddedCount) { }

	[Address(RVA = "0x32CFFD0", Offset = "0x32CF3D0", Length = "0x27")]
	[Token(Token = "0x6002611")]
	public void CloneTree(VisualElement target) { }

	[Address(RVA = "0x32D0000", Offset = "0x32CF400", Length = "0x45")]
	[Token(Token = "0x6002610")]
	public TemplateContainer CloneTree(string bindingPath) { }

	[Address(RVA = "0x32D0300", Offset = "0x32CF700", Length = "0x9")]
	[Token(Token = "0x600260F")]
	public TemplateContainer CloneTree() { }

	[Address(RVA = "0x32D0310", Offset = "0x32CF710", Length = "0x755")]
	[Token(Token = "0x600261F")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal static VisualElement Create(VisualElementAsset asset, CreationContext ctx) { }

	[Address(RVA = "0x32D0C70", Offset = "0x32D0070", Length = "0x8E")]
	[IteratorStateMachine(typeof(<DepthFirstTraversal>d__88))]
	[Token(Token = "0x6002626")]
	internal IEnumerable<UxmlAsset> DepthFirstTraversal(UxmlAsset asset) { }

	[Address(RVA = "0x32D0C10", Offset = "0x32D0010", Length = "0x52")]
	[Token(Token = "0x6002624")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal IEnumerable<UxmlAsset> DepthFirstTraversal() { }

	[Address(RVA = "0x32D0A70", Offset = "0x32CFE70", Length = "0x19B")]
	[Token(Token = "0x6002627")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal int DepthFirstTraversalIndexOf(UxmlAsset uxmlAsset) { }

	[Address(RVA = "0x84D610", Offset = "0x84CA10", Length = "0x89")]
	[IteratorStateMachine(typeof(<DepthFirstTraversalOfType>d__87`1))]
	[Token(Token = "0x6002625")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal IEnumerable<T> DepthFirstTraversalOfType() { }

	[Address(RVA = "0x32D0D00", Offset = "0x32D0100", Length = "0xFB")]
	[Token(Token = "0x6002628")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal int GenerateNewId(VisualElementAsset vea) { }

	[Address(RVA = "0x2F98AE0", Offset = "0x2F97EE0", Length = "0x6")]
	[Token(Token = "0x600260B")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal int get_contentContainerId() { }

	[Address(RVA = "0x2F91150", Offset = "0x2F90550", Length = "0x6")]
	[Token(Token = "0x6002622")]
	public int get_contentHash() { }

	[Address(RVA = "0x2F8BC90", Offset = "0x2F8B090", Length = "0x7")]
	[Token(Token = "0x60025F0")]
	internal bool get_hasEditorElements() { }

	[Address(RVA = "0x2F8BCB0", Offset = "0x2F8B0B0", Length = "0x7")]
	[Token(Token = "0x60025EE")]
	public bool get_importedWithErrors() { }

	[Address(RVA = "0x2F98AF0", Offset = "0x2F97EF0", Length = "0x7")]
	[Token(Token = "0x60025F4")]
	public bool get_importedWithWarnings() { }

	[Address(RVA = "0x2F8BCA0", Offset = "0x2F8B0A0", Length = "0x7")]
	[Token(Token = "0x60025F2")]
	internal bool get_importerWithUpdatedUrls() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x600260A")]
	internal List<SlotDefinition> get_slots() { }

	[Address(RVA = "0x32D3E40", Offset = "0x32D3240", Length = "0x71")]
	[IteratorStateMachine(typeof(<get_stylesheets>d__40))]
	[Token(Token = "0x60025FD")]
	public IEnumerable<StyleSheet> get_stylesheets() { }

	[Address(RVA = "0x32D3EC0", Offset = "0x32D32C0", Length = "0x71")]
	[IteratorStateMachine(typeof(<get_templateDependencies>d__30))]
	[Token(Token = "0x60025F8")]
	public IEnumerable<VisualTreeAsset> get_templateDependencies() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60025F7")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal List<UsingEntry> get_usings() { }

	[Address(RVA = "0x32D3F40", Offset = "0x32D3340", Length = "0x623")]
	[Token(Token = "0x60025FB")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal VisualElementAsset get_visualTree() { }

	[Address(RVA = "0x2F94490", Offset = "0x2F93890", Length = "0x7")]
	[Token(Token = "0x60025FA")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal VisualElementAsset get_visualTreeNoAlloc() { }

	[Address(RVA = "0x32D0F80", Offset = "0x32D0380", Length = "0x212")]
	[Token(Token = "0x6002607")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal object GetAsset(string path, Type type) { }

	[Address(RVA = "0x9E4D10", Offset = "0x9E4110", Length = "0x9E")]
	[Token(Token = "0x6002606")]
	internal T GetAsset(string path) { }

	[Address(RVA = "0x32D0E00", Offset = "0x32D0200", Length = "0x17E")]
	[Token(Token = "0x6002608")]
	internal Type GetAssetType(string path) { }

	[Address(RVA = "0x32D11A0", Offset = "0x32D05A0", Length = "0x65")]
	[Token(Token = "0x60025F6")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal int GetNextChildSerialNumber() { }

	[Address(RVA = "0x32D1210", Offset = "0x32D0610", Length = "0xA8")]
	[Token(Token = "0x60025FF")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal int GetNextUxmlAssetId(int parentId) { }

	[Address(RVA = "0x32D12C0", Offset = "0x32D06C0", Length = "0x9A")]
	[Token(Token = "0x60025F9")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal StyleSheet GetOrCreateInlineStyleSheet() { }

	[Address(RVA = "0x32D1360", Offset = "0x32D0760", Length = "0x517")]
	[Token(Token = "0x6002609")]
	internal IBaseUxmlObjectFactory GetUxmlObjectFactory(UxmlObjectAsset uxmlObjectAsset) { }

	[Address(RVA = "0x9E5210", Offset = "0x9E4610", Length = "0x392")]
	[Token(Token = "0x6002602")]
	internal List<T> GetUxmlObjects(IUxmlAttributes asset, CreationContext cc) { }

	[Address(RVA = "0x32D1880", Offset = "0x32D0C80", Length = "0xF4")]
	[Token(Token = "0x600261E")]
	private void InsertUsingEntry(UsingEntry entry) { }

	[Address(RVA = "0x32D0000", Offset = "0x32CF400", Length = "0x45")]
	[Token(Token = "0x600260E")]
	public TemplateContainer Instantiate(string bindingPath) { }

	[Address(RVA = "0x32D1980", Offset = "0x32D0D80", Length = "0x248")]
	[Token(Token = "0x600260D")]
	public TemplateContainer Instantiate() { }

	[Address(RVA = "0x32D1BD0", Offset = "0x32D0FD0", Length = "0x18F")]
	[Token(Token = "0x6002604")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void RegisterAssetEntry(string path, Type type, object asset) { }

	[Address(RVA = "0x32D1DE0", Offset = "0x32D11E0", Length = "0x80")]
	[Token(Token = "0x600261A")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void RegisterTemplate(string templateName, string path) { }

	[Address(RVA = "0x32D1D60", Offset = "0x32D1160", Length = "0x80")]
	[Token(Token = "0x600261B")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void RegisterTemplate(string templateName, VisualTreeAsset asset) { }

	[Address(RVA = "0x32D1E60", Offset = "0x32D1260", Length = "0x69")]
	[Token(Token = "0x6002617")]
	private void RemoveUsingEntry(UsingEntry entry) { }

	[Address(RVA = "0x32D1ED0", Offset = "0x32D12D0", Length = "0x158")]
	[Token(Token = "0x600262A")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal VisualElementAsset ReparentElementInDocument(VisualElementAsset vea, VisualElementAsset newParent, int index = -1) { }

	[Address(RVA = "0x32D2030", Offset = "0x32D1430", Length = "0x170")]
	[Token(Token = "0x6002618")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal VisualTreeAsset ResolveTemplate(string templateName) { }

	[Address(RVA = "0xE0D7D0", Offset = "0xE0CBD0", Length = "0x4")]
	[Token(Token = "0x600260C")]
	internal void set_contentContainerId(int value) { }

	[Address(RVA = "0xFE2A70", Offset = "0xFE1E70", Length = "0x4")]
	[Token(Token = "0x6002623")]
	public void set_contentHash(int value) { }

	[Address(RVA = "0x21BAC10", Offset = "0x21BA010", Length = "0x4")]
	[Token(Token = "0x60025F1")]
	internal void set_hasEditorElements(bool value) { }

	[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
	[Token(Token = "0x60025EF")]
	internal void set_importedWithErrors(bool value) { }

	[Address(RVA = "0x29EA840", Offset = "0x29E9C40", Length = "0x4")]
	[Token(Token = "0x60025F5")]
	internal void set_importedWithWarnings(bool value) { }

	[Address(RVA = "0x21BAC00", Offset = "0x21BA000", Length = "0x4")]
	[Token(Token = "0x60025F3")]
	internal void set_importerWithUpdatedUrls(bool value) { }

	[Address(RVA = "0x32D21A0", Offset = "0x32D15A0", Length = "0x8F")]
	[Token(Token = "0x60025FC")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void SetRootAsset(VisualElementAsset root) { }

	[Address(RVA = "0x32D2230", Offset = "0x32D1630", Length = "0x20B")]
	[Token(Token = "0x6002601")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void SetupReferences() { }

	[Address(RVA = "0x32D26B0", Offset = "0x32D1AB0", Length = "0x46E")]
	[Token(Token = "0x600262B")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void Swallow(VisualElementAsset parent, VisualTreeAsset other) { }

	[Address(RVA = "0x32D2440", Offset = "0x32D1840", Length = "0x261")]
	[Token(Token = "0x600262D")]
	internal static void SwallowStyleRule(VisualTreeAsset previous, VisualTreeAsset next, VisualElementAsset vea) { }

	[Address(RVA = "0x32D2B20", Offset = "0x32D1F20", Length = "0x140")]
	[Token(Token = "0x6002619")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal bool TemplateExists(string templateName) { }

	[Address(RVA = "0x32D2C70", Offset = "0x32D2070", Length = "0x8F")]
	[Token(Token = "0x6002605")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void TransferAssetEntries(VisualTreeAsset otherVta) { }

	[Address(RVA = "0x32D2D00", Offset = "0x32D2100", Length = "0xD6")]
	[Token(Token = "0x6002615")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal bool TryGetSlotInsertionPoint(int insertionPointId, out string slotName) { }

	[Address(RVA = "0x32D2DE0", Offset = "0x32D21E0", Length = "0x1A1")]
	[Token(Token = "0x6002616")]
	internal bool TryGetUsingEntry(string templateName, out UsingEntry entry) { }

	[Address(RVA = "0x32D2F90", Offset = "0x32D2390", Length = "0x3BC")]
	[Token(Token = "0x600261C")]
	internal bool TryRegisterTemplate(string templateName, VisualTreeAsset asset) { }

	[Address(RVA = "0x32D3350", Offset = "0x32D2750", Length = "0x3E9")]
	[Token(Token = "0x600261D")]
	internal bool TryUnregisterTemplate(string templateName) { }

	[Address(RVA = "0x32D38D0", Offset = "0x32D2CD0", Length = "0x32A")]
	[Token(Token = "0x600262C")]
	private static void UpdateUxmlObjectAssetsParentId(VisualElementAsset visualElementAsset) { }

}

