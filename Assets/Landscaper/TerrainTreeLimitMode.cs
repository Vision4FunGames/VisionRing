namespace Landscaper
{
	/// <summary>
	/// Defines the method used to handle the Unity cap of 65,535 terrain trees per terrain before LODs stop working properly
	/// </summary>
	public enum TerrainTreeLimitMode
	{
		Ignore,     // Ignore the cap and keep placing terrain trees
		Limit,      // Limit the number of terrain trees placed to the cap
		Replace,    // Any terrain trees placed above the cap are replaced with GameObjects
	}
}
