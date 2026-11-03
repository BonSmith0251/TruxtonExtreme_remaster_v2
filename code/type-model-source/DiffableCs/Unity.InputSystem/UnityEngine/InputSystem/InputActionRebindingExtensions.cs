namespace UnityEngine.InputSystem;

[Extension]
[Token(Token = "0x2000033")]
public static class InputActionRebindingExtensions
{
	[CompilerGenerated]
	[Token(Token = "0x200003C")]
	private sealed class <>c__DisplayClass25_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400015F")]
		public ReadOnlyArray<InputBinding> bindings; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000160")]
		public int firstPartIndex; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000161")]
		public String[] partStrings; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000162")]
		public int partCount; //Field offset: 0x30

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000284")]
		public <>c__DisplayClass25_0() { }

		[Address(RVA = "0x290B820", Offset = "0x290AC20", Length = "0x152")]
		[Token(Token = "0x6000285")]
		internal string <GetBindingDisplayString>b__0(string fragment) { }

	}

	[Token(Token = "0x200003B")]
	public class DeferBindingResolutionWrapper : IDisposable
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000283")]
		public DeferBindingResolutionWrapper() { }

		[Address(RVA = "0x28FB580", Offset = "0x28FA980", Length = "0x53")]
		[Token(Token = "0x6000281")]
		public void Acquire() { }

		[Address(RVA = "0x28FB5E0", Offset = "0x28FA9E0", Length = "0xD0")]
		[Token(Token = "0x6000282")]
		public override void Dispose() { }

	}

	[Token(Token = "0x2000034")]
	public struct Parameter
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000117")]
		public object instance; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000118")]
		public FieldInfo field; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000119")]
		public int bindingIndex; //Field offset: 0x10

	}

	[Token(Token = "0x2000035")]
	private struct ParameterEnumerable : IEnumerable<Parameter>, IEnumerable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400011A")]
		private InputActionState m_State; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400011B")]
		private ParameterOverride m_Parameter; //Field offset: 0x8
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x400011C")]
		private int m_MapIndex; //Field offset: 0x80

		[Address(RVA = "0x28EBA90", Offset = "0x28EAE90", Length = "0x82")]
		[Token(Token = "0x6000230")]
		public ParameterEnumerable(InputActionState state, ParameterOverride parameter, int mapIndex = -1) { }

		[Address(RVA = "0x28EB7C0", Offset = "0x28EABC0", Length = "0x123")]
		[Token(Token = "0x6000231")]
		public ParameterEnumerator GetEnumerator() { }

		[Address(RVA = "0x28EB8F0", Offset = "0x28EACF0", Length = "0xC2")]
		[Token(Token = "0x6000232")]
		private override IEnumerator<Parameter> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputActionRebindingExtensions.Parameter>.GetEnumerator() { }

		[Address(RVA = "0x28EB9C0", Offset = "0x28EADC0", Length = "0xC2")]
		[Token(Token = "0x6000233")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[Token(Token = "0x2000036")]
	private struct ParameterEnumerator : IEnumerator<Parameter>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400011D")]
		private InputActionState m_State; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400011E")]
		private int m_MapIndex; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x400011F")]
		private int m_BindingCurrentIndex; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000120")]
		private int m_BindingEndIndex; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000121")]
		private int m_InteractionCurrentIndex; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000122")]
		private int m_InteractionEndIndex; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000123")]
		private int m_ProcessorCurrentIndex; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000124")]
		private int m_ProcessorEndIndex; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000125")]
		private InputBinding m_BindingMask; //Field offset: 0x28
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4000126")]
		private Type m_ObjectType; //Field offset: 0x80
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000127")]
		private string m_ParameterName; //Field offset: 0x88
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4000128")]
		private bool m_MayBeInteraction; //Field offset: 0x90
		[FieldOffset(Offset = "0x91")]
		[Token(Token = "0x4000129")]
		private bool m_MayBeProcessor; //Field offset: 0x91
		[FieldOffset(Offset = "0x92")]
		[Token(Token = "0x400012A")]
		private bool m_MayBeComposite; //Field offset: 0x92
		[FieldOffset(Offset = "0x93")]
		[Token(Token = "0x400012B")]
		private bool m_CurrentBindingIsComposite; //Field offset: 0x93
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x400012C")]
		private object m_CurrentObject; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x400012D")]
		private FieldInfo m_CurrentParameter; //Field offset: 0xA0

		[Token(Token = "0x170000C2")]
		public override Parameter Current
		{
			[Address(RVA = "0x28EC4B0", Offset = "0x28EB8B0", Length = "0x53")]
			[Token(Token = "0x600023B")]
			 get { } //Length: 83
		}

		[Token(Token = "0x170000C3")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x28EC150", Offset = "0x28EB550", Length = "0x8E")]
			[Token(Token = "0x600023C")]
			private get { } //Length: 142
		}

		[Address(RVA = "0x28EC1E0", Offset = "0x28EB5E0", Length = "0x2C8")]
		[Token(Token = "0x6000234")]
		public ParameterEnumerator(InputActionState state, ParameterOverride parameter, int mapIndex = -1) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x600023D")]
		public override void Dispose() { }

		[Address(RVA = "0x28EBB20", Offset = "0x28EAF20", Length = "0x119")]
		[Token(Token = "0x6000238")]
		private bool FindParameter(object instance) { }

		[Address(RVA = "0x28EC4B0", Offset = "0x28EB8B0", Length = "0x53")]
		[Token(Token = "0x600023B")]
		public override Parameter get_Current() { }

		[Address(RVA = "0x28EBC40", Offset = "0x28EB040", Length = "0x166")]
		[Token(Token = "0x6000239")]
		public override bool MoveNext() { }

		[Address(RVA = "0x28EBDB0", Offset = "0x28EB1B0", Length = "0x191")]
		[Token(Token = "0x6000235")]
		private bool MoveToNextBinding() { }

		[Address(RVA = "0x28EBF50", Offset = "0x28EB350", Length = "0x6C")]
		[Token(Token = "0x6000236")]
		private bool MoveToNextInteraction() { }

		[Address(RVA = "0x28EBFC0", Offset = "0x28EB3C0", Length = "0x6C")]
		[Token(Token = "0x6000237")]
		private bool MoveToNextProcessor() { }

		[Address(RVA = "0x28EC030", Offset = "0x28EB430", Length = "0x11D")]
		[Token(Token = "0x600023A")]
		public override void Reset() { }

		[Address(RVA = "0x28EC150", Offset = "0x28EB550", Length = "0x8E")]
		[Token(Token = "0x600023C")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[Token(Token = "0x2000037")]
	public struct ParameterOverride
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400012E")]
		public string objectRegistrationName; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400012F")]
		public string parameter; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000130")]
		public InputBinding bindingMask; //Field offset: 0x10
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000131")]
		public PrimitiveValue value; //Field offset: 0x68

		[Token(Token = "0x170000C4")]
		public Type objectType
		{
			[Address(RVA = "0x28ED1F0", Offset = "0x28EC5F0", Length = "0x9D")]
			[Token(Token = "0x600023E")]
			 get { } //Length: 157
		}

		[Address(RVA = "0x28ED0F0", Offset = "0x28EC4F0", Length = "0xFF")]
		[Token(Token = "0x600023F")]
		public ParameterOverride(string parameterName, InputBinding bindingMask, PrimitiveValue value = null) { }

		[Address(RVA = "0x28ED060", Offset = "0x28EC460", Length = "0x88")]
		[Token(Token = "0x6000240")]
		public ParameterOverride(string objectRegistrationName, string parameterName, InputBinding bindingMask, PrimitiveValue value = null) { }

		[Address(RVA = "0x28EC8E0", Offset = "0x28EBCE0", Length = "0x2D5")]
		[Token(Token = "0x6000241")]
		public static Nullable<ParameterOverride> Find(InputActionMap actionMap, ref InputBinding binding, string parameterName, string objectRegistrationName) { }

		[Address(RVA = "0x28EC510", Offset = "0x28EB910", Length = "0x3C6")]
		[Token(Token = "0x6000242")]
		private static Nullable<ParameterOverride> Find(ParameterOverride[] overrides, int overrideCount, ref InputBinding binding, string parameterName, string objectRegistrationName) { }

		[Address(RVA = "0x28ED1F0", Offset = "0x28EC5F0", Length = "0x9D")]
		[Token(Token = "0x600023E")]
		public Type get_objectType() { }

		[Address(RVA = "0x28ECBC0", Offset = "0x28EBFC0", Length = "0x496")]
		[Token(Token = "0x6000243")]
		private static Nullable<ParameterOverride> PickMoreSpecificOne(Nullable<ParameterOverride> first, Nullable<ParameterOverride> second) { }

	}

	[Token(Token = "0x2000038")]
	internal sealed class RebindingOperation : IDisposable
	{
		[CompilerGenerated]
		[Token(Token = "0x200003A")]
		private sealed class <>c__DisplayClass32_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400015E")]
			public string group; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600027F")]
			public <>c__DisplayClass32_0() { }

			[Address(RVA = "0x290B980", Offset = "0x290AD80", Length = "0x28")]
			[Token(Token = "0x6000280")]
			internal bool <WithTargetBinding>b__0(InputControlScheme x) { }

		}

		[Flags]
		[Token(Token = "0x2000039")]
		private enum Flags : int
		{
			Started = 1,
			Completed = 2,
			Canceled = 4,
			OnEventHooked = 8,
			OnAfterUpdateHooked = 16,
			DontIgnoreNoisyControls = 64,
			DontGeneralizePathOfSelectedControl = 128,
			AddNewBinding = 256,
			SuppressMatchingEvents = 512,
		}

		[Token(Token = "0x4000132")]
		public const float kDefaultMagnitudeThreshold = 0.2; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000133")]
		private InputAction m_ActionToRebind; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000134")]
		private Nullable<InputBinding> m_BindingMask; //Field offset: 0x18
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4000135")]
		private Type m_ControlType; //Field offset: 0x78
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4000136")]
		private InternedString m_ExpectedLayout; //Field offset: 0x80
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4000137")]
		private int m_IncludePathCount; //Field offset: 0x90
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4000138")]
		private String[] m_IncludePaths; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4000139")]
		private int m_ExcludePathCount; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x400013A")]
		private String[] m_ExcludePaths; //Field offset: 0xA8
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x400013B")]
		private int m_TargetBindingIndex; //Field offset: 0xB0
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x400013C")]
		private string m_BindingGroupForNewBinding; //Field offset: 0xB8
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x400013D")]
		private string m_CancelBinding; //Field offset: 0xC0
		[FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x400013E")]
		private float m_MagnitudeThreshold; //Field offset: 0xC8
		[FieldOffset(Offset = "0xD0")]
		[Token(Token = "0x400013F")]
		private Single[] m_Scores; //Field offset: 0xD0
		[FieldOffset(Offset = "0xD8")]
		[Token(Token = "0x4000140")]
		private Single[] m_Magnitudes; //Field offset: 0xD8
		[FieldOffset(Offset = "0xE0")]
		[Token(Token = "0x4000141")]
		private double m_LastMatchTime; //Field offset: 0xE0
		[FieldOffset(Offset = "0xE8")]
		[Token(Token = "0x4000142")]
		private double m_StartTime; //Field offset: 0xE8
		[FieldOffset(Offset = "0xF0")]
		[Token(Token = "0x4000143")]
		private float m_Timeout; //Field offset: 0xF0
		[FieldOffset(Offset = "0xF4")]
		[Token(Token = "0x4000144")]
		private float m_WaitSecondsAfterMatch; //Field offset: 0xF4
		[FieldOffset(Offset = "0xF8")]
		[Token(Token = "0x4000145")]
		private InputEventHandledPolicy m_SavedInputEventHandledPolicy; //Field offset: 0xF8
		[FieldOffset(Offset = "0xFC")]
		[Token(Token = "0x4000146")]
		private InputEventHandledPolicy m_TargetInputEventHandledPolicy; //Field offset: 0xFC
		[FieldOffset(Offset = "0x100")]
		[Token(Token = "0x4000147")]
		private InputControlList<InputControl> m_Candidates; //Field offset: 0x100
		[FieldOffset(Offset = "0x120")]
		[Token(Token = "0x4000148")]
		private Action<RebindingOperation> m_OnComplete; //Field offset: 0x120
		[FieldOffset(Offset = "0x128")]
		[Token(Token = "0x4000149")]
		private Action<RebindingOperation> m_OnCancel; //Field offset: 0x128
		[FieldOffset(Offset = "0x130")]
		[Token(Token = "0x400014A")]
		private Action<RebindingOperation> m_OnPotentialMatch; //Field offset: 0x130
		[FieldOffset(Offset = "0x138")]
		[Token(Token = "0x400014B")]
		private Func<InputControl, String> m_OnGeneratePath; //Field offset: 0x138
		[FieldOffset(Offset = "0x140")]
		[Token(Token = "0x400014C")]
		private Func<InputControl, InputEventPtr, Single> m_OnComputeScore; //Field offset: 0x140
		[FieldOffset(Offset = "0x148")]
		[Token(Token = "0x400014D")]
		private Action<RebindingOperation, String> m_OnApplyBinding; //Field offset: 0x148
		[FieldOffset(Offset = "0x150")]
		[Token(Token = "0x400014E")]
		private Action<InputEventPtr, InputDevice> m_OnEventDelegate; //Field offset: 0x150
		[FieldOffset(Offset = "0x158")]
		[Token(Token = "0x400014F")]
		private Action m_OnAfterUpdateDelegate; //Field offset: 0x158
		[FieldOffset(Offset = "0x160")]
		[Token(Token = "0x4000150")]
		private Cache m_LayoutCache; //Field offset: 0x160
		[FieldOffset(Offset = "0x168")]
		[Token(Token = "0x4000151")]
		private StringBuilder m_PathBuilder; //Field offset: 0x168
		[FieldOffset(Offset = "0x170")]
		[Token(Token = "0x4000152")]
		private Flags m_Flags; //Field offset: 0x170
		[FieldOffset(Offset = "0x178")]
		[Token(Token = "0x4000153")]
		private Dictionary<InputControl, Single> m_StartingActuations; //Field offset: 0x178

		[Token(Token = "0x170000C5")]
		public InputAction action
		{
			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[Token(Token = "0x6000244")]
			 get { } //Length: 5
		}

		[Token(Token = "0x170000C6")]
		public Nullable<InputBinding> bindingMask
		{
			[Address(RVA = "0x19640A0", Offset = "0x19634A0", Length = "0x33")]
			[Token(Token = "0x6000245")]
			 get { } //Length: 51
		}

		[Token(Token = "0x170000CD")]
		public bool canceled
		{
			[Address(RVA = "0x28F1C00", Offset = "0x28F1000", Length = "0xB")]
			[Token(Token = "0x600024C")]
			 get { } //Length: 11
		}

		[Token(Token = "0x170000C7")]
		public InputControlList<InputControl> candidates
		{
			[Address(RVA = "0x28F1C10", Offset = "0x28F1010", Length = "0x19")]
			[Token(Token = "0x6000246")]
			 get { } //Length: 25
		}

		[Token(Token = "0x170000CC")]
		public bool completed
		{
			[Address(RVA = "0x28F1C30", Offset = "0x28F1030", Length = "0xB")]
			[Token(Token = "0x600024B")]
			 get { } //Length: 11
		}

		[Token(Token = "0x170000D0")]
		public string expectedControlType
		{
			[Address(RVA = "0x28F1C40", Offset = "0x28F1040", Length = "0x21")]
			[Token(Token = "0x600024F")]
			 get { } //Length: 33
		}

		[Token(Token = "0x170000C9")]
		public ReadOnlyArray<Single> magnitudes
		{
			[Address(RVA = "0x28F1C70", Offset = "0x28F1070", Length = "0x71")]
			[Token(Token = "0x6000248")]
			 get { } //Length: 113
		}

		[Token(Token = "0x170000C8")]
		public ReadOnlyArray<Single> scores
		{
			[Address(RVA = "0x28F1CF0", Offset = "0x28F10F0", Length = "0x71")]
			[Token(Token = "0x6000247")]
			 get { } //Length: 113
		}

		[Token(Token = "0x170000CA")]
		public InputControl selectedControl
		{
			[Address(RVA = "0x28F1D70", Offset = "0x28F1170", Length = "0x5C")]
			[Token(Token = "0x6000249")]
			 get { } //Length: 92
		}

		[Token(Token = "0x170000CB")]
		public bool started
		{
			[Address(RVA = "0x28F1DE0", Offset = "0x28F11E0", Length = "0xA")]
			[Token(Token = "0x600024A")]
			 get { } //Length: 10
		}

		[Token(Token = "0x170000CE")]
		public double startTime
		{
			[Address(RVA = "0x28F1DD0", Offset = "0x28F11D0", Length = "0x9")]
			[Token(Token = "0x600024D")]
			 get { } //Length: 9
		}

		[Token(Token = "0x170000CF")]
		public float timeout
		{
			[Address(RVA = "0x28F1DF0", Offset = "0x28F11F0", Length = "0x9")]
			[Token(Token = "0x600024E")]
			 get { } //Length: 9
		}

		[Address(RVA = "0x28F1B60", Offset = "0x28F0F60", Length = "0x91")]
		[Token(Token = "0x600027E")]
		public RebindingOperation() { }

		[Address(RVA = "0x28EE590", Offset = "0x28ED990", Length = "0x19D")]
		[Token(Token = "0x600026C")]
		public void AddCandidate(InputControl control, float score, float magnitude = -1) { }

		[Address(RVA = "0x28EE730", Offset = "0x28EDB30", Length = "0x4B")]
		[Token(Token = "0x600026A")]
		public void Cancel() { }

		[Address(RVA = "0x28EE780", Offset = "0x28EDB80", Length = "0x11")]
		[Token(Token = "0x600026B")]
		public void Complete() { }

		[Address(RVA = "0x28EE7A0", Offset = "0x28EDBA0", Length = "0xB1")]
		[Token(Token = "0x600026E")]
		public override void Dispose() { }

		[Address(RVA = "0x28EE860", Offset = "0x28EDC60", Length = "0xF5")]
		[Token(Token = "0x600026F")]
		protected virtual void Finalize() { }

		[Address(RVA = "0x28EE960", Offset = "0x28EDD60", Length = "0x141")]
		[Token(Token = "0x600027D")]
		private string GeneratePathForControl(InputControl control) { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000244")]
		public InputAction get_action() { }

		[Address(RVA = "0x19640A0", Offset = "0x19634A0", Length = "0x33")]
		[Token(Token = "0x6000245")]
		public Nullable<InputBinding> get_bindingMask() { }

		[Address(RVA = "0x28F1C00", Offset = "0x28F1000", Length = "0xB")]
		[Token(Token = "0x600024C")]
		public bool get_canceled() { }

		[Address(RVA = "0x28F1C10", Offset = "0x28F1010", Length = "0x19")]
		[Token(Token = "0x6000246")]
		public InputControlList<InputControl> get_candidates() { }

		[Address(RVA = "0x28F1C30", Offset = "0x28F1030", Length = "0xB")]
		[Token(Token = "0x600024B")]
		public bool get_completed() { }

		[Address(RVA = "0x28F1C40", Offset = "0x28F1040", Length = "0x21")]
		[Token(Token = "0x600024F")]
		public string get_expectedControlType() { }

		[Address(RVA = "0x28F1C70", Offset = "0x28F1070", Length = "0x71")]
		[Token(Token = "0x6000248")]
		public ReadOnlyArray<Single> get_magnitudes() { }

		[Address(RVA = "0x28F1CF0", Offset = "0x28F10F0", Length = "0x71")]
		[Token(Token = "0x6000247")]
		public ReadOnlyArray<Single> get_scores() { }

		[Address(RVA = "0x28F1D70", Offset = "0x28F1170", Length = "0x5C")]
		[Token(Token = "0x6000249")]
		public InputControl get_selectedControl() { }

		[Address(RVA = "0x28F1DE0", Offset = "0x28F11E0", Length = "0xA")]
		[Token(Token = "0x600024A")]
		public bool get_started() { }

		[Address(RVA = "0x28F1DD0", Offset = "0x28F11D0", Length = "0x9")]
		[Token(Token = "0x600024D")]
		public double get_startTime() { }

		[Address(RVA = "0x28F1DF0", Offset = "0x28F11F0", Length = "0x9")]
		[Token(Token = "0x600024E")]
		public float get_timeout() { }

		[Address(RVA = "0x28EEAB0", Offset = "0x28EDEB0", Length = "0x8F")]
		[Token(Token = "0x6000275")]
		private static bool HavePathMatch(InputControl control, String[] paths, int pathCount) { }

		[Address(RVA = "0x28EEB40", Offset = "0x28EDF40", Length = "0xC7")]
		[Token(Token = "0x6000276")]
		private void HookOnAfterUpdate() { }

		[Address(RVA = "0x28EEC10", Offset = "0x28EE010", Length = "0xDD")]
		[Token(Token = "0x6000271")]
		private void HookOnEvent() { }

		[Address(RVA = "0x28EECF0", Offset = "0x28EE0F0", Length = "0xBF")]
		[Token(Token = "0x6000278")]
		private void OnAfterUpdate() { }

		[Address(RVA = "0x28EEDB0", Offset = "0x28EE1B0", Length = "0x25")]
		[Token(Token = "0x6000266")]
		public RebindingOperation OnApplyBinding(Action<RebindingOperation, String> callback) { }

		[Address(RVA = "0x28EEE20", Offset = "0x28EE220", Length = "0x25")]
		[Token(Token = "0x6000262")]
		public RebindingOperation OnCancel(Action<RebindingOperation> callback) { }

		[Address(RVA = "0x28EEDE0", Offset = "0x28EE1E0", Length = "0x3C")]
		[Token(Token = "0x600027A")]
		private void OnCancel() { }

		[Address(RVA = "0x28EEE50", Offset = "0x28EE250", Length = "0x4C4")]
		[Token(Token = "0x6000279")]
		private void OnComplete() { }

		[Address(RVA = "0x28EF320", Offset = "0x28EE720", Length = "0x25")]
		[Token(Token = "0x6000261")]
		public RebindingOperation OnComplete(Action<RebindingOperation> callback) { }

		[Address(RVA = "0x28EF350", Offset = "0x28EE750", Length = "0x25")]
		[Token(Token = "0x6000265")]
		public RebindingOperation OnComputeScore(Func<InputControl, InputEventPtr, Single> callback) { }

		[Address(RVA = "0x28EF380", Offset = "0x28EE780", Length = "0x7D0")]
		[Token(Token = "0x6000273")]
		private void OnEvent(InputEventPtr eventPtr, InputDevice device) { }

		[Address(RVA = "0x28EFB60", Offset = "0x28EEF60", Length = "0x25")]
		[Token(Token = "0x6000264")]
		public RebindingOperation OnGeneratePath(Func<InputControl, String> callback) { }

		[Address(RVA = "0x28EFB90", Offset = "0x28EEF90", Length = "0xC")]
		[Token(Token = "0x6000267")]
		public RebindingOperation OnMatchWaitForAnother(float seconds) { }

		[Address(RVA = "0x28EFBA0", Offset = "0x28EEFA0", Length = "0x25")]
		[Token(Token = "0x6000263")]
		public RebindingOperation OnPotentialMatch(Action<RebindingOperation> callback) { }

		[Address(RVA = "0x28EFBD0", Offset = "0x28EEFD0", Length = "0x107")]
		[Token(Token = "0x600026D")]
		public void RemoveCandidate(InputControl control) { }

		[Address(RVA = "0x28EFE40", Offset = "0x28EF240", Length = "0x122")]
		[Token(Token = "0x6000270")]
		public RebindingOperation Reset() { }

		[Address(RVA = "0x28EFCE0", Offset = "0x28EF0E0", Length = "0x152")]
		[Token(Token = "0x600027B")]
		private void ResetAfterMatchCompleted() { }

		[Address(RVA = "0x28EFF70", Offset = "0x28EF370", Length = "0x155")]
		[Token(Token = "0x6000274")]
		private void SortCandidatesByScore() { }

		[Address(RVA = "0x28F00D0", Offset = "0x28EF4D0", Length = "0x3F9")]
		[Token(Token = "0x6000269")]
		public RebindingOperation Start() { }

		[Address(RVA = "0x28F04D0", Offset = "0x28EF8D0", Length = "0x64")]
		[Token(Token = "0x600027C")]
		private void ThrowIfRebindInProgress() { }

		[Address(RVA = "0x28F0540", Offset = "0x28EF940", Length = "0x6B")]
		[Token(Token = "0x6000277")]
		private void UnhookOnAfterUpdate() { }

		[Address(RVA = "0x28F05B0", Offset = "0x28EF9B0", Length = "0x73")]
		[Token(Token = "0x6000272")]
		private void UnhookOnEvent() { }

		[Address(RVA = "0x28F06A0", Offset = "0x28EFAA0", Length = "0x1C6")]
		[Token(Token = "0x6000250")]
		public RebindingOperation WithAction(InputAction action) { }

		[Address(RVA = "0x28F0630", Offset = "0x28EFA30", Length = "0x70")]
		[Token(Token = "0x6000268")]
		public RebindingOperation WithActionEventNotificationsBeingSuppressed(bool value = true) { }

		[Address(RVA = "0x28F0870", Offset = "0x28EFC70", Length = "0x128")]
		[Token(Token = "0x6000259")]
		public RebindingOperation WithBindingGroup(string group) { }

		[Address(RVA = "0x28F09A0", Offset = "0x28EFDA0", Length = "0x4C")]
		[Token(Token = "0x6000258")]
		public RebindingOperation WithBindingMask(Nullable<InputBinding> bindingMask) { }

		[Address(RVA = "0x28F0A70", Offset = "0x28EFE70", Length = "0xC8")]
		[Token(Token = "0x6000253")]
		public RebindingOperation WithCancelingThrough(InputControl control) { }

		[Address(RVA = "0x28F09F0", Offset = "0x28EFDF0", Length = "0x76")]
		[Token(Token = "0x6000252")]
		public RebindingOperation WithCancelingThrough(string binding) { }

		[Address(RVA = "0x28F0B40", Offset = "0x28EFF40", Length = "0x18D")]
		[Token(Token = "0x600025F")]
		public RebindingOperation WithControlsExcluding(string path) { }

		[Address(RVA = "0x28F0CD0", Offset = "0x28F00D0", Length = "0x18D")]
		[Token(Token = "0x600025E")]
		public RebindingOperation WithControlsHavingToMatchPath(string path) { }

		[Address(RVA = "0x9F6380", Offset = "0x9F5780", Length = "0x67")]
		[Token(Token = "0x6000256")]
		public RebindingOperation WithExpectedControlType() { }

		[Address(RVA = "0x28F0E60", Offset = "0x28F0260", Length = "0x1B5")]
		[Token(Token = "0x6000255")]
		public RebindingOperation WithExpectedControlType(Type type) { }

		[Address(RVA = "0x28F1020", Offset = "0x28F0420", Length = "0x92")]
		[Token(Token = "0x6000254")]
		public RebindingOperation WithExpectedControlType(string layoutName) { }

		[Address(RVA = "0x28F10C0", Offset = "0x28F04C0", Length = "0xFD")]
		[Token(Token = "0x600025C")]
		public RebindingOperation WithMagnitudeHavingToBeGreaterThan(float magnitude) { }

		[Address(RVA = "0x28F11C0", Offset = "0x28F05C0", Length = "0x87")]
		[Token(Token = "0x6000251")]
		public RebindingOperation WithMatchingEventsBeingSuppressed(bool value = true) { }

		[Address(RVA = "0x28F1AE0", Offset = "0x28F0EE0", Length = "0xE")]
		[Token(Token = "0x600025A")]
		public RebindingOperation WithoutGeneralizingPathOfSelectedControl() { }

		[Address(RVA = "0x28F1AF0", Offset = "0x28F0EF0", Length = "0x6E")]
		[Token(Token = "0x600025D")]
		public RebindingOperation WithoutIgnoringNoisyControls() { }

		[Address(RVA = "0x28F1250", Offset = "0x28F0650", Length = "0x2F")]
		[Token(Token = "0x600025B")]
		public RebindingOperation WithRebindAddingNewBinding(string group = null) { }

		[Address(RVA = "0x28F1280", Offset = "0x28F0680", Length = "0x7EB")]
		[Token(Token = "0x6000257")]
		public RebindingOperation WithTargetBinding(int bindingIndex) { }

		[Address(RVA = "0x28F1A70", Offset = "0x28F0E70", Length = "0x6F")]
		[Token(Token = "0x6000260")]
		public RebindingOperation WithTimeout(float timeInSeconds) { }

	}

	[Token(Token = "0x4000116")]
	private static DeferBindingResolutionWrapper s_DeferBindingResolutionWrapper; //Field offset: 0x0

	[Address(RVA = "0x28E0ED0", Offset = "0x28E02D0", Length = "0x259")]
	[Extension]
	[Token(Token = "0x600022A")]
	private static void AddBindingOverrideJsonTo(IInputActionCollection2 actions, InputBinding binding, List<BindingOverrideJson> list, InputAction action = null) { }

	[Address(RVA = "0x28E1130", Offset = "0x28E0530", Length = "0x11A")]
	[Extension]
	[Token(Token = "0x6000219")]
	public static void ApplyBindingOverride(InputAction action, string newPath, string group = null, string path = null) { }

	[Address(RVA = "0x28E1250", Offset = "0x28E0650", Length = "0x1C0")]
	[Extension]
	[Token(Token = "0x600021C")]
	public static void ApplyBindingOverride(InputAction action, int bindingIndex, string path) { }

	[Address(RVA = "0x28E16C0", Offset = "0x28E0AC0", Length = "0x1E5")]
	[Extension]
	[Token(Token = "0x600021D")]
	public static int ApplyBindingOverride(InputActionMap actionMap, InputBinding bindingOverride) { }

	[Address(RVA = "0x28E18B0", Offset = "0x28E0CB0", Length = "0x1E9")]
	[Extension]
	[Token(Token = "0x600021E")]
	public static void ApplyBindingOverride(InputActionMap actionMap, int bindingIndex, InputBinding bindingOverride) { }

	[Address(RVA = "0x28E15D0", Offset = "0x28E09D0", Length = "0xEC")]
	[Extension]
	[Token(Token = "0x600021B")]
	public static void ApplyBindingOverride(InputAction action, int bindingIndex, InputBinding bindingOverride) { }

	[Address(RVA = "0x28E1420", Offset = "0x28E0820", Length = "0x1A9")]
	[Extension]
	[Token(Token = "0x600021A")]
	public static void ApplyBindingOverride(InputAction action, InputBinding bindingOverride) { }

	[Address(RVA = "0x28E1E50", Offset = "0x28E1250", Length = "0x2B5")]
	[Extension]
	[Token(Token = "0x6000224")]
	public static void ApplyBindingOverrides(InputActionMap actionMap, IEnumerable<InputBinding> overrides) { }

	[Address(RVA = "0x28E1C20", Offset = "0x28E1020", Length = "0x226")]
	[Extension]
	[Token(Token = "0x6000226")]
	public static int ApplyBindingOverridesOnMatchingControls(InputAction action, InputControl control) { }

	[Address(RVA = "0x28E1AA0", Offset = "0x28E0EA0", Length = "0x179")]
	[Extension]
	[Token(Token = "0x6000227")]
	public static int ApplyBindingOverridesOnMatchingControls(InputActionMap actionMap, InputControl control) { }

	[Address(RVA = "0x833570", Offset = "0x832970", Length = "0x249")]
	[Extension]
	[Token(Token = "0x6000208")]
	public static void ApplyParameterOverride(InputActionMap actionMap, Expression<Func`2<TObject, TValue>> expr, TValue value, InputBinding bindingMask = null) { }

	[Address(RVA = "0x28E34B0", Offset = "0x28E28B0", Length = "0x35F")]
	[Extension]
	[Token(Token = "0x600020C")]
	public static void ApplyParameterOverride(InputActionAsset asset, string name, PrimitiveValue value, InputBinding bindingMask = null) { }

	[Address(RVA = "0x28E2C10", Offset = "0x28E2010", Length = "0x2DA")]
	[Extension]
	[Token(Token = "0x600020D")]
	public static void ApplyParameterOverride(InputAction action, string name, PrimitiveValue value, InputBinding bindingMask = null) { }

	[Address(RVA = "0x28E31A0", Offset = "0x28E25A0", Length = "0x307")]
	[Extension]
	[Token(Token = "0x600020E")]
	public static void ApplyParameterOverride(InputAction action, string name, PrimitiveValue value, int bindingIndex) { }

	[Address(RVA = "0x28E2110", Offset = "0x28E1510", Length = "0xAF8")]
	[Token(Token = "0x600020F")]
	private static void ApplyParameterOverride(InputActionState state, int mapIndex, ref ParameterOverride[] parameterOverrides, ref int parameterOverridesCount, ParameterOverride parameterOverride) { }

	[Address(RVA = "0x8337C0", Offset = "0x832BC0", Length = "0x2DD")]
	[Extension]
	[Token(Token = "0x6000207")]
	public static void ApplyParameterOverride(InputAction action, Expression<Func`2<TObject, TValue>> expr, TValue value, InputBinding bindingMask = null) { }

	[Address(RVA = "0x8332E0", Offset = "0x8326E0", Length = "0x28D")]
	[Extension]
	[Token(Token = "0x6000209")]
	public static void ApplyParameterOverride(InputActionAsset asset, Expression<Func`2<TObject, TValue>> expr, TValue value, InputBinding bindingMask = null) { }

	[Address(RVA = "0x28E2EF0", Offset = "0x28E22F0", Length = "0x2AB")]
	[Extension]
	[Token(Token = "0x600020B")]
	public static void ApplyParameterOverride(InputActionMap actionMap, string name, PrimitiveValue value, InputBinding bindingMask = null) { }

	[Address(RVA = "0x28E3810", Offset = "0x28E2C10", Length = "0xC2")]
	[Token(Token = "0x600022F")]
	internal static DeferBindingResolutionWrapper DeferBindingResolution() { }

	[Address(RVA = "0x833AA0", Offset = "0x832EA0", Length = "0x610")]
	[Token(Token = "0x600020A")]
	private static ParameterOverride ExtractParameterOverride(Expression<Func`2<TObject, TValue>> expr, InputBinding bindingMask = null, PrimitiveValue value = null) { }

	[Address(RVA = "0x28E42C0", Offset = "0x28E36C0", Length = "0x310")]
	[Extension]
	[Token(Token = "0x6000216")]
	public static string GetBindingDisplayString(InputAction action, InputBinding bindingMask, DisplayStringOptions options = 0) { }

	[Address(RVA = "0x28E38E0", Offset = "0x28E2CE0", Length = "0x85")]
	[Extension]
	[Token(Token = "0x6000217")]
	public static string GetBindingDisplayString(InputAction action, int bindingIndex, DisplayStringOptions options = 0) { }

	[Address(RVA = "0x28E3970", Offset = "0x28E2D70", Length = "0x6E7")]
	[Extension]
	[Token(Token = "0x6000218")]
	public static string GetBindingDisplayString(InputAction action, int bindingIndex, out string deviceLayoutName, out string controlPath, DisplayStringOptions options = 0) { }

	[Address(RVA = "0x28E4060", Offset = "0x28E3460", Length = "0x255")]
	[Extension]
	[Token(Token = "0x6000215")]
	public static string GetBindingDisplayString(InputAction action, DisplayStringOptions options = 0, string group = null) { }

	[Address(RVA = "0x28E45E0", Offset = "0x28E39E0", Length = "0x28F")]
	[Extension]
	[Token(Token = "0x6000213")]
	public static Nullable<InputBinding> GetBindingForControl(InputAction action, InputControl control) { }

	[Address(RVA = "0x28E4C80", Offset = "0x28E4080", Length = "0x25B")]
	[Extension]
	[Token(Token = "0x6000212")]
	public static int GetBindingIndex(InputAction action, string group = null, string path = null) { }

	[Address(RVA = "0x28E4EE0", Offset = "0x28E42E0", Length = "0x1B3")]
	[Extension]
	[Token(Token = "0x6000211")]
	public static int GetBindingIndex(InputActionMap actionMap, InputBinding bindingMask) { }

	[Address(RVA = "0x28E4A80", Offset = "0x28E3E80", Length = "0x1F5")]
	[Extension]
	[Token(Token = "0x6000210")]
	public static int GetBindingIndex(InputAction action, InputBinding bindingMask) { }

	[Address(RVA = "0x28E4870", Offset = "0x28E3C70", Length = "0x20E")]
	[Extension]
	[Token(Token = "0x6000214")]
	public static int GetBindingIndexForControl(InputAction action, InputControl control) { }

	[Address(RVA = "0x28E5310", Offset = "0x28E4710", Length = "0x416")]
	[Extension]
	[Token(Token = "0x6000204")]
	private static Nullable<PrimitiveValue> GetParameterValue(InputAction action, ParameterOverride parameterOverride) { }

	[Address(RVA = "0x28E5730", Offset = "0x28E4B30", Length = "0x310")]
	[Extension]
	[Token(Token = "0x6000205")]
	public static Nullable<PrimitiveValue> GetParameterValue(InputAction action, string name, int bindingIndex) { }

	[Address(RVA = "0x8340C0", Offset = "0x8334C0", Length = "0x540")]
	[Extension]
	[Token(Token = "0x6000206")]
	public static Nullable<TValue> GetParameterValue(InputAction action, Expression<Func`2<TObject, TValue>> expr, InputBinding bindingMask = null) { }

	[Address(RVA = "0x28E50A0", Offset = "0x28E44A0", Length = "0x26B")]
	[Extension]
	[Token(Token = "0x6000203")]
	public static Nullable<PrimitiveValue> GetParameterValue(InputAction action, string name, InputBinding bindingMask = null) { }

	[Address(RVA = "0x28E5F60", Offset = "0x28E5360", Length = "0x11E")]
	[Extension]
	[Token(Token = "0x600022B")]
	public static void LoadBindingOverridesFromJson(IInputActionCollection2 actions, string json, bool removeExisting = true) { }

	[Address(RVA = "0x28E6080", Offset = "0x28E5480", Length = "0x128")]
	[Extension]
	[Token(Token = "0x600022C")]
	public static void LoadBindingOverridesFromJson(InputAction action, string json, bool removeExisting = true) { }

	[Address(RVA = "0x28E5A50", Offset = "0x28E4E50", Length = "0x501")]
	[Extension]
	[Token(Token = "0x600022D")]
	private static void LoadBindingOverridesFromJsonInternal(IInputActionCollection2 actions, string json) { }

	[Address(RVA = "0x28E61B0", Offset = "0x28E55B0", Length = "0x5BD")]
	[Extension]
	[Token(Token = "0x600022E")]
	public static RebindingOperation PerformInteractiveRebinding(InputAction action, int bindingIndex = -1) { }

	[Address(RVA = "0x28E6A90", Offset = "0x28E5E90", Length = "0x1D8")]
	[Extension]
	[Token(Token = "0x6000223")]
	public static void RemoveAllBindingOverrides(InputAction action) { }

	[Address(RVA = "0x28E6770", Offset = "0x28E5B70", Length = "0x31C")]
	[Extension]
	[Token(Token = "0x6000222")]
	public static void RemoveAllBindingOverrides(IInputActionCollection2 actions) { }

	[Address(RVA = "0x28E6EA0", Offset = "0x28E62A0", Length = "0xF5")]
	[Extension]
	[Token(Token = "0x6000221")]
	private static void RemoveBindingOverride(InputActionMap actionMap, InputBinding bindingMask) { }

	[Address(RVA = "0x28E6C70", Offset = "0x28E6070", Length = "0xF5")]
	[Extension]
	[Token(Token = "0x6000220")]
	public static void RemoveBindingOverride(InputAction action, InputBinding bindingMask) { }

	[Address(RVA = "0x28E6D70", Offset = "0x28E6170", Length = "0x12E")]
	[Extension]
	[Token(Token = "0x600021F")]
	public static void RemoveBindingOverride(InputAction action, int bindingIndex) { }

	[Address(RVA = "0x28E6FA0", Offset = "0x28E63A0", Length = "0x345")]
	[Extension]
	[Token(Token = "0x6000225")]
	public static void RemoveBindingOverrides(InputActionMap actionMap, IEnumerable<InputBinding> overrides) { }

	[Address(RVA = "0x28E72F0", Offset = "0x28E66F0", Length = "0x357")]
	[Extension]
	[Token(Token = "0x6000228")]
	public static string SaveBindingOverridesAsJson(IInputActionCollection2 actions) { }

	[Address(RVA = "0x28E7650", Offset = "0x28E6A50", Length = "0x433")]
	[Extension]
	[Token(Token = "0x6000229")]
	public static string SaveBindingOverridesAsJson(InputAction action) { }

}

