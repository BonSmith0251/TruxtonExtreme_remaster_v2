namespace System.Runtime.CompilerServices;

[DebuggerStepThrough]
[EditorBrowsable(EditorBrowsableState::Never (1))]
[Token(Token = "0x200024F")]
public static class CallSiteOps
{

	[Address(RVA = "0x79BCC0", Offset = "0x79B0C0", Length = "0x53")]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	[Token(Token = "0x6000B48")]
	public static void AddRule(CallSite<T> site, T rule) { }

	[Address(RVA = "0x79BD20", Offset = "0x79B120", Length = "0x19A")]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	[Token(Token = "0x6000B4E")]
	public static T Bind(CallSiteBinder binder, CallSite<T> site, Object[] args) { }

	[Address(RVA = "0x2291D10", Offset = "0x2291110", Length = "0x17")]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	[Token(Token = "0x6000B47")]
	public static void ClearMatch(CallSite site) { }

	[Address(RVA = "0x79BEC0", Offset = "0x79B2C0", Length = "0x4D")]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	[Token(Token = "0x6000B44")]
	public static CallSite<T> CreateMatchmaker(CallSite<T> site) { }

	[Address(RVA = "0x79BF10", Offset = "0x79B310", Length = "0x2C")]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	[Token(Token = "0x6000B4D")]
	public static T[] GetCachedRules(RuleCache<T> cache) { }

	[Address(RVA = "0x1411980", Offset = "0x1410D80", Length = "0x17")]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	[Token(Token = "0x6000B46")]
	public static bool GetMatch(CallSite site) { }

	[Address(RVA = "0x79BF40", Offset = "0x79B340", Length = "0x49")]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	[Token(Token = "0x6000B4B")]
	public static RuleCache<T> GetRuleCache(CallSite<T> site) { }

	[Address(RVA = "0x79BF90", Offset = "0x79B390", Length = "0x17")]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	[Token(Token = "0x6000B4A")]
	public static T[] GetRules(CallSite<T> site) { }

	[Address(RVA = "0x79BFB0", Offset = "0x79B3B0", Length = "0x69")]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	[Token(Token = "0x6000B4C")]
	public static void MoveRule(RuleCache<T> cache, T rule, int i) { }

	[Address(RVA = "0x2291D30", Offset = "0x2291130", Length = "0x1B")]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	[Token(Token = "0x6000B45")]
	public static bool SetNotMatched(CallSite site) { }

	[Address(RVA = "0x79C020", Offset = "0x79B420", Length = "0x57")]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	[Token(Token = "0x6000B49")]
	public static void UpdateRules(CallSite<T> this, int matched) { }

}

