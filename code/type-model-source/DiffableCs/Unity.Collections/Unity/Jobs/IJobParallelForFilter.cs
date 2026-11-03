namespace Unity.Jobs;

[Obsolete("'IJobParallelForFilter' has been deprecated; use 'IJobFilter' instead. (UnityUpgradable) -> IJobFilter")]
[Token(Token = "0x2000009")]
public interface IJobParallelForFilter
{

	[Token(Token = "0x6000010")]
	public bool Execute(int index) { }

}

