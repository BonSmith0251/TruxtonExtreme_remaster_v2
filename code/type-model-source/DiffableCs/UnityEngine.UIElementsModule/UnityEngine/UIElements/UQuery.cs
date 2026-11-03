namespace UnityEngine.UIElements;

[Token(Token = "0x20004D1")]
public static class UQuery
{
	[Token(Token = "0x20004D7")]
	public class FirstQueryMatcher : SingleQueryMatcher
	{
		[Token(Token = "0x4001051")]
		public static readonly FirstQueryMatcher Instance; //Field offset: 0x0

		[Address(RVA = "0x32B9D10", Offset = "0x32B9110", Length = "0x67")]
		[Token(Token = "0x60024CC")]
		private static FirstQueryMatcher() { }

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60024CB")]
		public FirstQueryMatcher() { }

		[Address(RVA = "0x32B9C90", Offset = "0x32B9090", Length = "0x44")]
		[Token(Token = "0x60024CA")]
		public virtual SingleQueryMatcher CreateNew() { }

		[Address(RVA = "0x32B9CE0", Offset = "0x32B90E0", Length = "0x22")]
		[Token(Token = "0x60024C9")]
		protected virtual bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element) { }

	}

	[Token(Token = "0x20004D3")]
	public class IsOfType : IVisualPredicateWrapper
	{
		[Token(Token = "0x400104C")]
		public static IsOfType<T> s_Instance; //Field offset: 0x0

		[Address(RVA = "0xABE850", Offset = "0xABDC50", Length = "0xEA")]
		[Token(Token = "0x60024B9")]
		private static IsOfType`1() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60024B8")]
		public IsOfType`1() { }

		[Address(RVA = "0xABE810", Offset = "0xABDC10", Length = "0x3F")]
		[Token(Token = "0x60024B7")]
		public override bool Predicate(object e) { }

	}

	[Token(Token = "0x20004D2")]
	public interface IVisualPredicateWrapper
	{

		[Token(Token = "0x60024B6")]
		public bool Predicate(object e) { }

	}

	[Token(Token = "0x20004D6")]
	public abstract class SingleQueryMatcher : UQueryMatcher
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001050")]
		private VisualElement <match>k__BackingField; //Field offset: 0x18

		[Token(Token = "0x170009B4")]
		public VisualElement match
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60024C3")]
			 get { } //Length: 5
			[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x60024C4")]
			 set { } //Length: 13
		}

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60024C8")]
		protected SingleQueryMatcher() { }

		[Token(Token = "0x60024C7")]
		public abstract SingleQueryMatcher CreateNew() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60024C3")]
		public VisualElement get_match() { }

		[Address(RVA = "0x32BA210", Offset = "0x32B9610", Length = "0xB")]
		[Token(Token = "0x60024C6")]
		public bool IsInUse() { }

		[Address(RVA = "0x32BA220", Offset = "0x32B9620", Length = "0x76")]
		[Token(Token = "0x60024C5")]
		public virtual void Run(VisualElement root, List<RuleMatcher> matchers) { }

		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60024C4")]
		public void set_match(VisualElement value) { }

	}

	[Token(Token = "0x20004D4")]
	public abstract class UQueryMatcher : HierarchyTraversal
	{
		[CompilerGenerated]
		[Token(Token = "0x20004D5")]
		private sealed class <>c
		{
			[Token(Token = "0x400104E")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x400104F")]
			public static Action<VisualElement, MatchResultInfo> <>9__5_0; //Field offset: 0x8

			[Address(RVA = "0x32BB290", Offset = "0x32BA690", Length = "0x67")]
			[Token(Token = "0x60024C0")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60024C1")]
			public <>c() { }

			[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
			[Token(Token = "0x60024C2")]
			internal void <TraverseRecursive>b__5_0(VisualElement e, MatchResultInfo i) { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400104D")]
		internal List<RuleMatcher> m_Matchers; //Field offset: 0x10

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60024BA")]
		protected UQueryMatcher() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60024BD")]
		private static void NoProcessResult(VisualElement e, MatchResultInfo i) { }

		[Address(RVA = "0x8E85F0", Offset = "0x8E79F0", Length = "0x5")]
		[Token(Token = "0x60024BC")]
		protected override bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element) { }

		[Address(RVA = "0x32C1350", Offset = "0x32C0750", Length = "0x44")]
		[Token(Token = "0x60024BF")]
		public override void Run(VisualElement root, List<RuleMatcher> matchers) { }

		[Address(RVA = "0x32C15C0", Offset = "0x32C09C0", Length = "0x8")]
		[Token(Token = "0x60024BB")]
		public virtual void Traverse(VisualElement element) { }

		[Address(RVA = "0x32C13A0", Offset = "0x32C07A0", Length = "0x217")]
		[Token(Token = "0x60024BE")]
		public virtual void TraverseRecursive(VisualElement element, int depth) { }

	}


}

