namespace UnityEngine.UIElements;

[Token(Token = "0x200025E")]
internal class DefaultEventSystem
{
	[CompilerGenerated]
	[Token(Token = "0x2000269")]
	private sealed class <>c
	{
		[Token(Token = "0x400097B")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x33F45A0", Offset = "0x33F39A0", Length = "0x67")]
		[Token(Token = "0x60010D8")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60010D9")]
		public <>c() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60010DA")]
		internal bool <.cctor>b__62_0() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200026A")]
	private sealed class <>c__35
	{
		[Token(Token = "0x400097C")]
		public static readonly <>c__35<TArg> <>9; //Field offset: 0x0
		[Token(Token = "0x400097D")]
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"evtFactory", "delta", "arg"})]
		public static Func<Vector3, ValueTuple`3<Func`4<Vector3, Vector3, TArg, EventBase>, Vector3, TArg>, EventBase> <>9__35_0; //Field offset: 0x0

		[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
		[Token(Token = "0x60010DB")]
		private static <>c__35`1() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60010DC")]
		public <>c__35`1() { }

		[Address(RVA = "0xA52710", Offset = "0xA51B10", Length = "0x19B")]
		[Token(Token = "0x60010DD")]
		internal EventBase <SendPositionBasedEvent>b__35_0(Vector3 p, ValueTuple<Func`4<Vector3, Vector3, TArg, EventBase>, Vector3, TArg> t) { }

	}

	[Token(Token = "0x2000260")]
	public struct FocusBasedEventSequenceContext : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400094B")]
		private DefaultEventSystem es; //Field offset: 0x0

		[Address(RVA = "0x33E45A0", Offset = "0x33E39A0", Length = "0x70")]
		[Token(Token = "0x6001072")]
		public FocusBasedEventSequenceContext(DefaultEventSystem es) { }

		[Address(RVA = "0x33E4550", Offset = "0x33E3950", Length = "0x49")]
		[Token(Token = "0x6001073")]
		public override void Dispose() { }

	}

	[Token(Token = "0x2000261")]
	private class InputForUIProcessor
	{
		[CompilerGenerated]
		[Token(Token = "0x2000262")]
		private sealed class <>c
		{
			[Token(Token = "0x4000950")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x4000951")]
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"pointerEvent", "pointerId", "deltaTime"})]
			public static Func<Vector3, ValueTuple`3<PointerEvent, Int32, Single>, EventBase> <>9__9_0; //Field offset: 0x8
			[Token(Token = "0x4000952")]
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"pointerEvent", "pointerId", "deltaTime"})]
			public static Func<Vector3, ValueTuple`3<PointerEvent, Int32, Single>, EventBase> <>9__9_1; //Field offset: 0x10
			[Token(Token = "0x4000953")]
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"pointerEvent", "pointerId", "deltaTime"})]
			public static Func<Vector3, ValueTuple`3<PointerEvent, Int32, Single>, EventBase> <>9__9_2; //Field offset: 0x18
			[Token(Token = "0x4000954")]
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"pointerEvent", "pointerId", "deltaTime"})]
			public static Func<Vector3, ValueTuple`3<PointerEvent, Int32, Single>, EventBase> <>9__9_3; //Field offset: 0x20
			[Token(Token = "0x4000955")]
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"move", "deviceType", "mod"})]
			public static Func<ValueTuple`3<Vector2, NavigationDeviceType, EventModifiers>, EventBase> <>9__10_2; //Field offset: 0x28
			[Token(Token = "0x4000956")]
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"direction", "deviceType", "mod"})]
			public static Func<ValueTuple`3<Direction, NavigationDeviceType, EventModifiers>, EventBase> <>9__10_3; //Field offset: 0x30
			[Token(Token = "0x4000957")]
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"deviceType", "mod"})]
			public static Func<ValueTuple`2<NavigationDeviceType, EventModifiers>, EventBase> <>9__10_0; //Field offset: 0x38
			[Token(Token = "0x4000958")]
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"deviceType", "mod"})]
			public static Func<ValueTuple`2<NavigationDeviceType, EventModifiers>, EventBase> <>9__10_1; //Field offset: 0x40
			[Token(Token = "0x4000959")]
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"modifiers", "keyCode"})]
			public static Func<ValueTuple`2<EventModifiers, KeyCode>, EventBase> <>9__11_0; //Field offset: 0x48
			[Token(Token = "0x400095A")]
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"modifiers", "keyCode"})]
			public static Func<ValueTuple`2<EventModifiers, KeyCode>, EventBase> <>9__11_1; //Field offset: 0x50
			[Token(Token = "0x400095B")]
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"modifiers", "character"})]
			public static Func<ValueTuple`2<EventModifiers, Char>, EventBase> <>9__12_0; //Field offset: 0x58

			[Address(RVA = "0x33F4680", Offset = "0x33F3A80", Length = "0x67")]
			[Token(Token = "0x6001080")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6001081")]
			public <>c() { }

			[Address(RVA = "0x33F33B0", Offset = "0x33F27B0", Length = "0x43")]
			[Token(Token = "0x600108A")]
			internal EventBase <ProcessKeyEvent>b__11_0(ValueTuple<EventModifiers, KeyCode> t) { }

			[Address(RVA = "0x33F3400", Offset = "0x33F2800", Length = "0x43")]
			[Token(Token = "0x600108B")]
			internal EventBase <ProcessKeyEvent>b__11_1(ValueTuple<EventModifiers, KeyCode> t) { }

			[Address(RVA = "0x33F3690", Offset = "0x33F2A90", Length = "0x40")]
			[Token(Token = "0x6001088")]
			internal EventBase <ProcessNavigationEvent>b__10_0(ValueTuple<NavigationDeviceType, EventModifiers> t) { }

			[Address(RVA = "0x33F36D0", Offset = "0x33F2AD0", Length = "0x40")]
			[Token(Token = "0x6001089")]
			internal EventBase <ProcessNavigationEvent>b__10_1(ValueTuple<NavigationDeviceType, EventModifiers> t) { }

			[Address(RVA = "0x33F3710", Offset = "0x33F2B10", Length = "0x51")]
			[Token(Token = "0x6001086")]
			internal EventBase <ProcessNavigationEvent>b__10_2(ValueTuple<Vector2, NavigationDeviceType, EventModifiers> t) { }

			[Address(RVA = "0x33F3770", Offset = "0x33F2B70", Length = "0x50")]
			[Token(Token = "0x6001087")]
			internal EventBase <ProcessNavigationEvent>b__10_3(ValueTuple<Direction, NavigationDeviceType, EventModifiers> t) { }

			[Address(RVA = "0x33F38B0", Offset = "0x33F2CB0", Length = "0x11B")]
			[Token(Token = "0x6001082")]
			internal EventBase <ProcessPointerEvent>b__9_0(Vector3 panelPosition, ValueTuple<PointerEvent, Int32, Single> t) { }

			[Address(RVA = "0x33F39D0", Offset = "0x33F2DD0", Length = "0x11B")]
			[Token(Token = "0x6001083")]
			internal EventBase <ProcessPointerEvent>b__9_1(Vector3 panelPosition, ValueTuple<PointerEvent, Int32, Single> t) { }

			[Address(RVA = "0x33F3AF0", Offset = "0x33F2EF0", Length = "0x11B")]
			[Token(Token = "0x6001084")]
			internal EventBase <ProcessPointerEvent>b__9_2(Vector3 panelPosition, ValueTuple<PointerEvent, Int32, Single> t) { }

			[Address(RVA = "0x33F3C10", Offset = "0x33F3010", Length = "0x11B")]
			[Token(Token = "0x6001085")]
			internal EventBase <ProcessPointerEvent>b__9_3(Vector3 panelPosition, ValueTuple<PointerEvent, Int32, Single> t) { }

			[Address(RVA = "0x33F3DD0", Offset = "0x33F31D0", Length = "0x44")]
			[Token(Token = "0x600108C")]
			internal EventBase <ProcessTextInputEvent>b__12_0(ValueTuple<EventModifiers, Char> t) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000263")]
		private sealed class <>c__DisplayClass14_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400095C")]
			public IMECompositionEvent compositionEvent; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600108D")]
			public <>c__DisplayClass14_0() { }

			[Address(RVA = "0x33F44E0", Offset = "0x33F38E0", Length = "0x4D")]
			[Token(Token = "0x600108E")]
			internal EventBase <ProcessIMECompositionEvent>b__0(int _) { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400094C")]
		private readonly DefaultEventSystem m_EventSystem; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400094D")]
		private DiscreteTime m_LastPointerTimestamp; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400094E")]
		private DiscreteTime m_NextPointerTimestamp; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400094F")]
		private readonly Queue<Event> m_EventList; //Field offset: 0x28

		[Address(RVA = "0x33EACB0", Offset = "0x33EA0B0", Length = "0xE2")]
		[Token(Token = "0x6001074")]
		public InputForUIProcessor(DefaultEventSystem eventSystem) { }

		[Address(RVA = "0x33EABD0", Offset = "0x33E9FD0", Length = "0xD7")]
		[CompilerGenerated]
		[Token(Token = "0x600107F")]
		private EventBase <ProcessPointerEvent>b__9_4(Vector3 panelPosition, ValueTuple<PointerEvent, Int32, Single> t) { }

		[Address(RVA = "0x33E82D0", Offset = "0x33E76D0", Length = "0xAE")]
		[Token(Token = "0x6001078")]
		private EventModifiers GetModifiers(EventModifiers eventModifiers) { }

		[Address(RVA = "0x33E8380", Offset = "0x33E7780", Length = "0xC1")]
		[Token(Token = "0x6001076")]
		public bool OnEvent(in Event ev) { }

		[Address(RVA = "0x33E8450", Offset = "0x33E7850", Length = "0x89")]
		[Token(Token = "0x600107D")]
		private void ProcessCommandEvent(CommandEvent commandEvent) { }

		[Address(RVA = "0x33E84E0", Offset = "0x33E78E0", Length = "0x145")]
		[Token(Token = "0x600107E")]
		private void ProcessIMECompositionEvent(IMECompositionEvent compositionEvent) { }

		[Address(RVA = "0x33E8630", Offset = "0x33E7A30", Length = "0x644")]
		[Token(Token = "0x6001077")]
		public void ProcessInputForUIEvents() { }

		[Address(RVA = "0x33E8C90", Offset = "0x33E8090", Length = "0x30C")]
		[Token(Token = "0x600107B")]
		private void ProcessKeyEvent(KeyEvent keyEvent) { }

		[Address(RVA = "0x33E8FA0", Offset = "0x33E83A0", Length = "0x684")]
		[Token(Token = "0x600107A")]
		private void ProcessNavigationEvent(NavigationEvent navigationEvent) { }

		[Address(RVA = "0x33E9630", Offset = "0x33E8A30", Length = "0x1310")]
		[Token(Token = "0x6001079")]
		private void ProcessPointerEvent(PointerEvent pointerEvent) { }

		[Address(RVA = "0x33EA950", Offset = "0x33E9D50", Length = "0x1D3")]
		[Token(Token = "0x600107C")]
		private void ProcessTextInputEvent(TextInputEvent textInputEvent) { }

		[Address(RVA = "0x33EAB30", Offset = "0x33E9F30", Length = "0x92")]
		[Token(Token = "0x6001075")]
		public void Reset() { }

	}

	[Token(Token = "0x2000264")]
	public class LegacyInputProcessor
	{
		[CompilerGenerated]
		[Token(Token = "0x2000268")]
		private sealed class <>c
		{
			[Token(Token = "0x400096E")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x400096F")]
			public static Func<Event, EventBase> <>9__28_0; //Field offset: 0x8
			[Token(Token = "0x4000970")]
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"modifiers", "scrollDelta"})]
			public static Func<Vector3, Vector3, ValueTuple`2<EventModifiers, Vector2>, EventBase> <>9__28_1; //Field offset: 0x10
			[Token(Token = "0x4000971")]
			public static Func<Vector3, Vector3, Event, EventBase> <>9__28_2; //Field offset: 0x18
			[Token(Token = "0x4000972")]
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"modifiers", "targetDisplay"})]
			public static Func<Vector3, Vector3, ValueTuple`2<EventModifiers, Nullable`1<Int32>>, EventBase> <>9__29_0; //Field offset: 0x20
			[Token(Token = "0x4000973")]
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"button", "clickCount", "modifiers", "targetDisplay"})]
			public static Func<Vector3, Vector3, ValueTuple`4<Int32, Int32, EventModifiers, Nullable`1<Int32>>, EventBase> <>9__29_1; //Field offset: 0x28
			[Token(Token = "0x4000974")]
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"button", "clickCount", "modifiers", "targetDisplay"})]
			public static Func<Vector3, Vector3, ValueTuple`4<Int32, Int32, EventModifiers, Nullable`1<Int32>>, EventBase> <>9__29_2; //Field offset: 0x30
			[Token(Token = "0x4000975")]
			public static Func<LegacyInputProcessor, EventBase> <>9__30_0; //Field offset: 0x38
			[Token(Token = "0x4000976")]
			public static Func<LegacyInputProcessor, EventBase> <>9__30_1; //Field offset: 0x40
			[Token(Token = "0x4000977")]
			public static Func<LegacyInputProcessor, EventBase> <>9__30_2; //Field offset: 0x48
			[Token(Token = "0x4000978")]
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"touch", "pointerId", "targetDisplay"})]
			public static Func<Vector3, Vector3, ValueTuple`3<Touch, Int32, Nullable`1<Int32>>, EventBase> <>9__31_0; //Field offset: 0x50
			[Token(Token = "0x4000979")]
			public static Func<Vector3, Vector3, PenData, EventBase> <>9__32_0; //Field offset: 0x58
			[Token(Token = "0x400097A")]
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"direction", "modifiers", "input"})]
			public static Func<ValueTuple`3<Direction, EventModifiers, IInput>, EventBase> <>9__39_0; //Field offset: 0x60

			[Address(RVA = "0x33F46F0", Offset = "0x33F3AF0", Length = "0x67")]
			[Token(Token = "0x60010CA")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60010CB")]
			public <>c() { }

			[Address(RVA = "0x33F3450", Offset = "0x33F2850", Length = "0xBA")]
			[Token(Token = "0x60010CF")]
			internal EventBase <ProcessMouseEvents>b__29_0(Vector3 panelPosition, Vector3 panelDelta, ValueTuple<EventModifiers, Nullable`1<Int32>> t) { }

			[Address(RVA = "0x33F3510", Offset = "0x33F2910", Length = "0xBC")]
			[Token(Token = "0x60010D0")]
			internal EventBase <ProcessMouseEvents>b__29_1(Vector3 panelPosition, Vector3 panelDelta, ValueTuple<Int32, Int32, EventModifiers, Nullable`1<Int32>> t) { }

			[Address(RVA = "0x33F35D0", Offset = "0x33F29D0", Length = "0xBF")]
			[Token(Token = "0x60010D1")]
			internal EventBase <ProcessMouseEvents>b__29_2(Vector3 panelPosition, Vector3 panelDelta, ValueTuple<Int32, Int32, EventModifiers, Nullable`1<Int32>> t) { }

			[Address(RVA = "0x33F37C0", Offset = "0x33F2BC0", Length = "0xE6")]
			[Token(Token = "0x60010D6")]
			internal EventBase <ProcessPenEvents>b__32_0(Vector3 panelPosition, Vector3 panelDelta, PenData _pen) { }

			[Address(RVA = "0x33F3D30", Offset = "0x33F3130", Length = "0x97")]
			[Token(Token = "0x60010D7")]
			internal EventBase <ProcessTabEvent>b__39_0(ValueTuple<Direction, EventModifiers, IInput> t) { }

			[Address(RVA = "0x33F3E20", Offset = "0x33F3220", Length = "0x1B4")]
			[Token(Token = "0x60010D5")]
			internal EventBase <ProcessTouchEvents>b__31_0(Vector3 panelPosition, Vector3 panelDelta, ValueTuple<Touch, Int32, Nullable`1<Int32>> t) { }

			[Address(RVA = "0x33F3FE0", Offset = "0x33F33E0", Length = "0x49")]
			[Token(Token = "0x60010CC")]
			internal EventBase <SendIMGUIEvents>b__28_0(Event e) { }

			[Address(RVA = "0x33F4030", Offset = "0x33F3430", Length = "0xA2")]
			[Token(Token = "0x60010CD")]
			internal EventBase <SendIMGUIEvents>b__28_1(Vector3 panelPosition, Vector3 _, ValueTuple<EventModifiers, Vector2> t) { }

			[Address(RVA = "0x33F40E0", Offset = "0x33F34E0", Length = "0xA8")]
			[Token(Token = "0x60010CE")]
			internal EventBase <SendIMGUIEvents>b__28_2(Vector3 panelPosition, Vector3 panelDelta, Event evt) { }

			[Address(RVA = "0x33F4190", Offset = "0x33F3590", Length = "0x8A")]
			[Token(Token = "0x60010D2")]
			internal EventBase <SendInputEvents>b__30_0(LegacyInputProcessor self) { }

			[Address(RVA = "0x33F4220", Offset = "0x33F3620", Length = "0xA0")]
			[Token(Token = "0x60010D3")]
			internal EventBase <SendInputEvents>b__30_1(LegacyInputProcessor self) { }

			[Address(RVA = "0x33F42D0", Offset = "0x33F36D0", Length = "0xA0")]
			[Token(Token = "0x60010D4")]
			internal EventBase <SendInputEvents>b__30_2(LegacyInputProcessor self) { }

		}

		[Token(Token = "0x2000265")]
		public interface IInput
		{

			[Token(Token = "0x17000314")]
			public bool anyKey
			{
				[Token(Token = "0x60010A9")]
				 get { } //Length: 0
			}

			[Token(Token = "0x17000316")]
			public float doubleClickTime
			{
				[Token(Token = "0x60010AB")]
				 get { } //Length: 0
			}

			[Token(Token = "0x17000313")]
			public int mouseButtonCount
			{
				[Token(Token = "0x60010A8")]
				 get { } //Length: 0
			}

			[Token(Token = "0x17000312")]
			public Vector3 mousePosition
			{
				[Token(Token = "0x60010A7")]
				 get { } //Length: 0
			}

			[Token(Token = "0x17000311")]
			public bool mousePresent
			{
				[Token(Token = "0x60010A4")]
				 get { } //Length: 0
			}

			[Token(Token = "0x17000310")]
			public int touchCount
			{
				[Token(Token = "0x60010A2")]
				 get { } //Length: 0
			}

			[Token(Token = "0x17000315")]
			public float unscaledTime
			{
				[Token(Token = "0x60010AA")]
				 get { } //Length: 0
			}

			[Token(Token = "0x60010A0")]
			public void ClearLastPenContactEvent() { }

			[Token(Token = "0x60010A9")]
			public bool get_anyKey() { }

			[Token(Token = "0x60010AB")]
			public float get_doubleClickTime() { }

			[Token(Token = "0x60010A8")]
			public int get_mouseButtonCount() { }

			[Token(Token = "0x60010A7")]
			public Vector3 get_mousePosition() { }

			[Token(Token = "0x60010A4")]
			public bool get_mousePresent() { }

			[Token(Token = "0x60010A2")]
			public int get_touchCount() { }

			[Token(Token = "0x60010AA")]
			public float get_unscaledTime() { }

			[Token(Token = "0x600109F")]
			public float GetAxisRaw(string axis) { }

			[Token(Token = "0x600109E")]
			public bool GetButtonDown(string button) { }

			[Token(Token = "0x60010A1")]
			public PenData GetLastPenContactEvent() { }

			[Token(Token = "0x60010A5")]
			public bool GetMouseButtonDown(int button) { }

			[Token(Token = "0x60010A6")]
			public bool GetMouseButtonUp(int button) { }

			[Token(Token = "0x60010A3")]
			public Touch GetTouch(int index) { }

		}

		[Token(Token = "0x2000266")]
		private class Input : IInput
		{

			[Token(Token = "0x1700031B")]
			public override bool anyKey
			{
				[Address(RVA = "0x33EADC0", Offset = "0x33EA1C0", Length = "0x7")]
				[Token(Token = "0x60010B7")]
				 get { } //Length: 7
			}

			[Token(Token = "0x1700031D")]
			public override float doubleClickTime
			{
				[Address(RVA = "0x33EADD0", Offset = "0x33EA1D0", Length = "0x1F")]
				[Token(Token = "0x60010B9")]
				 get { } //Length: 31
			}

			[Token(Token = "0x1700031A")]
			public override int mouseButtonCount
			{
				[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
				[Token(Token = "0x60010B6")]
				 get { } //Length: 6
			}

			[Token(Token = "0x17000319")]
			public override Vector3 mousePosition
			{
				[Address(RVA = "0x310E5A0", Offset = "0x310D9A0", Length = "0x2C")]
				[Token(Token = "0x60010B5")]
				 get { } //Length: 44
			}

			[Token(Token = "0x17000318")]
			public override bool mousePresent
			{
				[Address(RVA = "0x310E5D0", Offset = "0x310D9D0", Length = "0x7")]
				[Token(Token = "0x60010B2")]
				 get { } //Length: 7
			}

			[Token(Token = "0x17000317")]
			public override int touchCount
			{
				[Address(RVA = "0x310E5F0", Offset = "0x310D9F0", Length = "0x7")]
				[Token(Token = "0x60010B0")]
				 get { } //Length: 7
			}

			[Token(Token = "0x1700031C")]
			public override float unscaledTime
			{
				[Address(RVA = "0x2A13000", Offset = "0x2A12400", Length = "0x7")]
				[Token(Token = "0x60010B8")]
				 get { } //Length: 7
			}

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60010BA")]
			public Input() { }

			[Address(RVA = "0x33EADA0", Offset = "0x33EA1A0", Length = "0x7")]
			[Token(Token = "0x60010AE")]
			public override void ClearLastPenContactEvent() { }

			[Address(RVA = "0x33EADC0", Offset = "0x33EA1C0", Length = "0x7")]
			[Token(Token = "0x60010B7")]
			public override bool get_anyKey() { }

			[Address(RVA = "0x33EADD0", Offset = "0x33EA1D0", Length = "0x1F")]
			[Token(Token = "0x60010B9")]
			public override float get_doubleClickTime() { }

			[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
			[Token(Token = "0x60010B6")]
			public override int get_mouseButtonCount() { }

			[Address(RVA = "0x310E5A0", Offset = "0x310D9A0", Length = "0x2C")]
			[Token(Token = "0x60010B5")]
			public override Vector3 get_mousePosition() { }

			[Address(RVA = "0x310E5D0", Offset = "0x310D9D0", Length = "0x7")]
			[Token(Token = "0x60010B2")]
			public override bool get_mousePresent() { }

			[Address(RVA = "0x310E5F0", Offset = "0x310D9F0", Length = "0x7")]
			[Token(Token = "0x60010B0")]
			public override int get_touchCount() { }

			[Address(RVA = "0x2A13000", Offset = "0x2A12400", Length = "0x7")]
			[Token(Token = "0x60010B8")]
			public override float get_unscaledTime() { }

			[Address(RVA = "0x33EADB0", Offset = "0x33EA1B0", Length = "0xA")]
			[Token(Token = "0x60010AD")]
			public override float GetAxisRaw(string axis) { }

			[Address(RVA = "0x310E4B0", Offset = "0x310D8B0", Length = "0xA")]
			[Token(Token = "0x60010AC")]
			public override bool GetButtonDown(string button) { }

			[Address(RVA = "0x310E4D0", Offset = "0x310D8D0", Length = "0x36")]
			[Token(Token = "0x60010AF")]
			public override PenData GetLastPenContactEvent() { }

			[Address(RVA = "0x310E510", Offset = "0x310D910", Length = "0x9")]
			[Token(Token = "0x60010B3")]
			public override bool GetMouseButtonDown(int button) { }

			[Address(RVA = "0x310E520", Offset = "0x310D920", Length = "0x9")]
			[Token(Token = "0x60010B4")]
			public override bool GetMouseButtonUp(int button) { }

			[Address(RVA = "0x310E540", Offset = "0x310D940", Length = "0x46")]
			[Token(Token = "0x60010B1")]
			public override Touch GetTouch(int index) { }

		}

		[Token(Token = "0x2000267")]
		private class NoInput : IInput
		{

			[Token(Token = "0x17000322")]
			public override bool anyKey
			{
				[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
				[Token(Token = "0x60010C6")]
				 get { } //Length: 3
			}

			[Token(Token = "0x17000324")]
			public override float doubleClickTime
			{
				[Address(RVA = "0x33EF470", Offset = "0x33EE870", Length = "0x9")]
				[Token(Token = "0x60010C8")]
				 get { } //Length: 9
			}

			[Token(Token = "0x17000321")]
			public override int mouseButtonCount
			{
				[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
				[Token(Token = "0x60010C5")]
				 get { } //Length: 3
			}

			[Token(Token = "0x17000320")]
			public override Vector3 mousePosition
			{
				[Address(RVA = "0x2DC98B0", Offset = "0x2DC8CB0", Length = "0xC")]
				[Token(Token = "0x60010C4")]
				 get { } //Length: 12
			}

			[Token(Token = "0x1700031F")]
			public override bool mousePresent
			{
				[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
				[Token(Token = "0x60010C1")]
				 get { } //Length: 3
			}

			[Token(Token = "0x1700031E")]
			public override int touchCount
			{
				[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
				[Token(Token = "0x60010BD")]
				 get { } //Length: 3
			}

			[Token(Token = "0x17000323")]
			public override float unscaledTime
			{
				[Address(RVA = "0x661620", Offset = "0x660A20", Length = "0x4")]
				[Token(Token = "0x60010C7")]
				 get { } //Length: 4
			}

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60010C9")]
			public NoInput() { }

			[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
			[Token(Token = "0x60010BF")]
			public override void ClearLastPenContactEvent() { }

			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60010C6")]
			public override bool get_anyKey() { }

			[Address(RVA = "0x33EF470", Offset = "0x33EE870", Length = "0x9")]
			[Token(Token = "0x60010C8")]
			public override float get_doubleClickTime() { }

			[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
			[Token(Token = "0x60010C5")]
			public override int get_mouseButtonCount() { }

			[Address(RVA = "0x2DC98B0", Offset = "0x2DC8CB0", Length = "0xC")]
			[Token(Token = "0x60010C4")]
			public override Vector3 get_mousePosition() { }

			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60010C1")]
			public override bool get_mousePresent() { }

			[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
			[Token(Token = "0x60010BD")]
			public override int get_touchCount() { }

			[Address(RVA = "0x661620", Offset = "0x660A20", Length = "0x4")]
			[Token(Token = "0x60010C7")]
			public override float get_unscaledTime() { }

			[Address(RVA = "0x661620", Offset = "0x660A20", Length = "0x4")]
			[Token(Token = "0x60010BC")]
			public override float GetAxisRaw(string axis) { }

			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60010BB")]
			public override bool GetButtonDown(string button) { }

			[Address(RVA = "0x137D0E0", Offset = "0x137C4E0", Length = "0x14")]
			[Token(Token = "0x60010C0")]
			public override PenData GetLastPenContactEvent() { }

			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60010C2")]
			public override bool GetMouseButtonDown(int button) { }

			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60010C3")]
			public override bool GetMouseButtonUp(int button) { }

			[Address(RVA = "0x33EF450", Offset = "0x33EE850", Length = "0x1B")]
			[Token(Token = "0x60010BE")]
			public override Touch GetTouch(int index) { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400095D")]
		private bool m_SendingTouchEvents; //Field offset: 0x10
		[FieldOffset(Offset = "0x11")]
		[Token(Token = "0x400095E")]
		private bool m_SendingPenEvent; //Field offset: 0x11
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x400095F")]
		private EventModifiers m_CurrentModifiers; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000960")]
		private int m_LastMousePressButton; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000961")]
		private float m_NextMousePressTime; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000962")]
		private int m_LastMouseClickCount; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000963")]
		private Vector2 m_LastMousePosition; //Field offset: 0x24
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000964")]
		private bool m_MouseProcessedAtLeastOnce; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000965")]
		private Dictionary<Int32, Int32> m_TouchFingerIdToFingerIndex; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000966")]
		private int m_TouchNextFingerIndex; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000967")]
		private IInput m_Input; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000968")]
		private readonly Event m_Event; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000969")]
		private readonly DefaultEventSystem m_EventSystem; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x400096A")]
		private int m_ConsecutiveMoveCount; //Field offset: 0x58
		[FieldOffset(Offset = "0x5C")]
		[Token(Token = "0x400096B")]
		private Vector2 m_LastMoveVector; //Field offset: 0x5C
		[FieldOffset(Offset = "0x64")]
		[Token(Token = "0x400096C")]
		private float m_PrevActionTime; //Field offset: 0x64
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x400096D")]
		private bool m_IsMoveFromKeyboard; //Field offset: 0x68

		[Token(Token = "0x1700030F")]
		public IInput input
		{
			[Address(RVA = "0x33EDC50", Offset = "0x33ED050", Length = "0x3F")]
			[Token(Token = "0x6001090")]
			 get { } //Length: 63
		}

		[Token(Token = "0x1700030E")]
		private EventModifiers m_CurrentPointerModifiers
		{
			[Address(RVA = "0x33EDC90", Offset = "0x33ED090", Length = "0x7")]
			[Token(Token = "0x600108F")]
			private get { } //Length: 7
		}

		[Address(RVA = "0x33EDB30", Offset = "0x33ECF30", Length = "0x118")]
		[Token(Token = "0x6001091")]
		public LegacyInputProcessor(DefaultEventSystem eventSystem) { }

		[Address(RVA = "0x33EDC50", Offset = "0x33ED050", Length = "0x3F")]
		[Token(Token = "0x6001090")]
		public IInput get_input() { }

		[Address(RVA = "0x33EDC90", Offset = "0x33ED090", Length = "0x7")]
		[Token(Token = "0x600108F")]
		private EventModifiers get_m_CurrentPointerModifiers() { }

		[Address(RVA = "0x33EADF0", Offset = "0x33EA1F0", Length = "0xE3")]
		[Token(Token = "0x6001092")]
		public IInput GetDefaultInput() { }

		[Address(RVA = "0x33EAEE0", Offset = "0x33EA2E0", Length = "0x1FD")]
		[Token(Token = "0x6001099")]
		private Vector2 GetRawMoveVector() { }

		[Address(RVA = "0x33EB0E0", Offset = "0x33EA4E0", Length = "0xDA")]
		[Token(Token = "0x600109D")]
		private static EventBase MakePenEvent(PenData pen, EventModifiers modifiers, int targetDisplay) { }

		[Address(RVA = "0x33EB1C0", Offset = "0x33EA5C0", Length = "0x10C")]
		[Token(Token = "0x600109C")]
		private static EventBase MakeTouchEvent(Touch touch, int pointerId, EventModifiers modifiers, int targetDisplay) { }

		[Address(RVA = "0x33EB2D0", Offset = "0x33EA6D0", Length = "0x16E")]
		[Token(Token = "0x6001093")]
		public void ProcessLegacyInputEvents() { }

		[Address(RVA = "0x33EB440", Offset = "0x33EA840", Length = "0xB0A")]
		[Token(Token = "0x6001095")]
		private void ProcessMouseEvents() { }

		[Address(RVA = "0x33EBF50", Offset = "0x33EB350", Length = "0x3B6")]
		[Token(Token = "0x6001098")]
		private bool ProcessPenEvents() { }

		[Address(RVA = "0x33EC310", Offset = "0x33EB710", Length = "0x1D0")]
		[Token(Token = "0x600109B")]
		private void ProcessTabEvent(Event e, EventModifiers modifiers) { }

		[Address(RVA = "0x33EC4F0", Offset = "0x33EB8F0", Length = "0x724")]
		[Token(Token = "0x6001097")]
		private bool ProcessTouchEvents() { }

		[Address(RVA = "0x33ECC20", Offset = "0x33EC020", Length = "0x891")]
		[Token(Token = "0x6001094")]
		private void SendIMGUIEvents() { }

		[Address(RVA = "0x33ED4C0", Offset = "0x33EC8C0", Length = "0x38E")]
		[Token(Token = "0x6001096")]
		private void SendInputEvents() { }

		[Address(RVA = "0x33ED850", Offset = "0x33ECC50", Length = "0x2DE")]
		[Token(Token = "0x600109A")]
		private bool ShouldSendMoveFromInput() { }

	}

	[Token(Token = "0x200025F")]
	internal enum UpdateMode : int
	{
		Always = 0,
		IgnoreIfAppNotFocused = 1,
	}

	[Token(Token = "0x4000934")]
	internal static Func<Boolean> IsEditorRemoteConnected; //Field offset: 0x0
	[Token(Token = "0x4000943")]
	private static readonly Vector3 s_InvalidPanelCoordinates; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000935")]
	private RuntimePanel m_FocusedPanel; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000936")]
	private RuntimePanel m_PreviousFocusedPanel; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000937")]
	private Focusable m_PreviousFocusedElement; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000938")]
	private int m_UpdateFrameCount; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000939")]
	private LegacyInputProcessor m_LegacyInputProcessor; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400093A")]
	private InputForUIProcessor m_InputForUIProcessor; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400093B")]
	private bool m_IsInputReady; //Field offset: 0x40
	[FieldOffset(Offset = "0x41")]
	[Token(Token = "0x400093C")]
	private bool m_UseInputForUI; //Field offset: 0x41
	[FieldOffset(Offset = "0x42")]
	[Token(Token = "0x400093D")]
	private bool m_IsInputForUIActive; //Field offset: 0x42
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400093E")]
	private IScreenRaycaster m_Raycaster; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400093F")]
	private readonly PhysicsDocumentPicker m_WorldSpacePicker; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000940")]
	private readonly ScreenOverlayPanelPicker m_ScreenOverlayPicker; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000941")]
	public float worldSpaceMaxDistance; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000942")]
	public int worldSpaceLayers; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000944")]
	internal bool verbose; //Field offset: 0x68
	[FieldOffset(Offset = "0x69")]
	[Token(Token = "0x4000945")]
	internal bool logToGameScreen; //Field offset: 0x69
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000946")]
	private Label m_LogLabel; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000947")]
	private List<String> m_LogLines; //Field offset: 0x78

	[Token(Token = "0x17000309")]
	public RuntimePanel focusedPanel
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6001058")]
		 get { } //Length: 5
		[Address(RVA = "0x33E3490", Offset = "0x33E2890", Length = "0x51")]
		[Token(Token = "0x6001059")]
		 set { } //Length: 81
	}

	[Token(Token = "0x1700030B")]
	private InputForUIProcessor inputForUIProcessor
	{
		[Address(RVA = "0x33E4020", Offset = "0x33E3420", Length = "0x12C")]
		[Token(Token = "0x600105C")]
		private get { } //Length: 300
	}

	[Token(Token = "0x17000308")]
	private bool isAppFocused
	{
		[Address(RVA = "0x33E4150", Offset = "0x33E3550", Length = "0x40")]
		[Token(Token = "0x6001056")]
		private get { } //Length: 64
	}

	[Token(Token = "0x1700030C")]
	internal bool isInputReady
	{
		[Address(RVA = "0x33E43C0", Offset = "0x33E37C0", Length = "0xE3")]
		[Token(Token = "0x600105D")]
		internal set { } //Length: 227
	}

	[Token(Token = "0x1700030A")]
	internal LegacyInputProcessor legacyInputProcessor
	{
		[Address(RVA = "0x33E4190", Offset = "0x33E3590", Length = "0x162")]
		[Token(Token = "0x600105B")]
		internal get { } //Length: 354
	}

	[Token(Token = "0x1700030D")]
	public IScreenRaycaster raycaster
	{
		[Address(RVA = "0x33E4300", Offset = "0x33E3700", Length = "0xB1")]
		[Token(Token = "0x6001066")]
		 get { } //Length: 177
		[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
		[Token(Token = "0x6001067")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x33E3E20", Offset = "0x33E3220", Length = "0xEF")]
	[Token(Token = "0x6001071")]
	private static DefaultEventSystem() { }

	[Address(RVA = "0x33E3F10", Offset = "0x33E3310", Length = "0x106")]
	[Token(Token = "0x6001070")]
	public DefaultEventSystem() { }

	[Address(RVA = "0x33E1B50", Offset = "0x33E0F50", Length = "0xABD")]
	[Token(Token = "0x6001068")]
	internal void FindTargetAtPosition(Vector2 mousePosition, Vector2 delta, int pointerId, Nullable<Int32> targetDisplay, out VisualElement target, out RuntimePanel targetPanel, out Vector3 targetPanelPosition, out VisualElement elementUnderPointer, out Camera camera) { }

	[Address(RVA = "0x33E2610", Offset = "0x33E1A10", Length = "0x544")]
	[Token(Token = "0x6001069")]
	internal void FindTargetAtRay(Ray worldRay, float maxDistance, int pointerId, out VisualElement target, out RuntimePanel targetPanel, out Vector3 targetPanelPosition, out VisualElement elementUnderPointer) { }

	[Address(RVA = "0x33E2B60", Offset = "0x33E1F60", Length = "0x80")]
	[Token(Token = "0x600105E")]
	internal FocusBasedEventSequenceContext FocusBasedEventSequence() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6001058")]
	public RuntimePanel get_focusedPanel() { }

	[Address(RVA = "0x33E4020", Offset = "0x33E3420", Length = "0x12C")]
	[Token(Token = "0x600105C")]
	private InputForUIProcessor get_inputForUIProcessor() { }

	[Address(RVA = "0x33E4150", Offset = "0x33E3550", Length = "0x40")]
	[Token(Token = "0x6001056")]
	private bool get_isAppFocused() { }

	[Address(RVA = "0x33E4190", Offset = "0x33E3590", Length = "0x162")]
	[Token(Token = "0x600105B")]
	internal LegacyInputProcessor get_legacyInputProcessor() { }

	[Address(RVA = "0x33E4300", Offset = "0x33E3700", Length = "0xB1")]
	[Token(Token = "0x6001066")]
	public IScreenRaycaster get_raycaster() { }

	[Address(RVA = "0x33E2BF0", Offset = "0x33E1FF0", Length = "0x17A")]
	[Token(Token = "0x600106A")]
	private Vector3 GetPanelPosition(VisualElement pickedElement, UIDocument document, Ray worldRay) { }

	[Address(RVA = "0x33E2D70", Offset = "0x33E2170", Length = "0x1CA")]
	[Token(Token = "0x6001060")]
	private void InitInputProcessor() { }

	[Address(RVA = "0x33E33F0", Offset = "0x33E27F0", Length = "0x9D")]
	[Token(Token = "0x600106D")]
	private void Log(object o) { }

	[Address(RVA = "0x33E2F40", Offset = "0x33E2340", Length = "0x3EC")]
	[Token(Token = "0x600106F")]
	private void LogToGameScreen(string s) { }

	[Address(RVA = "0x33E3330", Offset = "0x33E2730", Length = "0xB4")]
	[Token(Token = "0x600106E")]
	private void LogWarning(object o) { }

	[Address(RVA = "0x33E3490", Offset = "0x33E2890", Length = "0x51")]
	[Token(Token = "0x6001061")]
	internal void OnFocusEvent(RuntimePanel panel, FocusEvent evt) { }

	[Address(RVA = "0x33E34F0", Offset = "0x33E28F0", Length = "0xBA")]
	[Token(Token = "0x600105F")]
	private void RemoveInputProcessor() { }

	[Address(RVA = "0x7CA230", Offset = "0x7C9630", Length = "0x495")]
	[Token(Token = "0x6001062")]
	internal void SendFocusBasedEvent(Func<TArg, EventBase> evtFactory, TArg arg) { }

	[Address(RVA = "0x7CBEE0", Offset = "0x7CB2E0", Length = "0x29D")]
	[Token(Token = "0x6001063")]
	internal void SendPositionBasedEvent(Vector3 mousePosition, Vector3 delta, int pointerId, Nullable<Int32> targetDisplay, Func<Vector3, Vector3, TArg, EventBase> evtFactory, TArg arg, bool deselectIfNoTarget = false) { }

	[Address(RVA = "0x7CC180", Offset = "0x7CB580", Length = "0x5DF")]
	[Token(Token = "0x6001064")]
	internal void SendPositionBasedEvent(Vector3 mousePosition, Vector3 delta, int pointerId, Nullable<Int32> targetDisplay, Func<Vector3, TArg, EventBase> evtFactory, TArg arg, bool deselectIfNoTarget = false) { }

	[Address(RVA = "0x7CEAC0", Offset = "0x7CDEC0", Length = "0x5DC")]
	[Token(Token = "0x6001065")]
	internal void SendRayBasedEvent(Ray worldRay, float maxDistance, int pointerId, Func<Vector3, TArg, EventBase> evtFactory, TArg arg, bool deselectIfNoTarget = false) { }

	[Address(RVA = "0x33E3490", Offset = "0x33E2890", Length = "0x51")]
	[Token(Token = "0x6001059")]
	public void set_focusedPanel(RuntimePanel value) { }

	[Address(RVA = "0x33E43C0", Offset = "0x33E37C0", Length = "0xE3")]
	[Token(Token = "0x600105D")]
	internal void set_isInputReady(bool value) { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[Token(Token = "0x6001067")]
	public void set_raycaster(IScreenRaycaster value) { }

	[Address(RVA = "0x33E35B0", Offset = "0x33E29B0", Length = "0x18")]
	[Token(Token = "0x6001057")]
	private bool ShouldIgnoreEventsOnAppNotFocused() { }

	[Address(RVA = "0x33E3BF0", Offset = "0x33E2FF0", Length = "0x22C")]
	[Token(Token = "0x600105A")]
	public void Update(UpdateMode updateMode = 0) { }

	[Address(RVA = "0x33E35D0", Offset = "0x33E29D0", Length = "0xDD")]
	[Token(Token = "0x600106B")]
	private void UpdateFocusedPanel(RuntimePanel runtimePanel) { }

	[Address(RVA = "0x33E36B0", Offset = "0x33E2AB0", Length = "0x538")]
	[Token(Token = "0x600106C")]
	private void UpdateWorldSpacePointers() { }

}

