namespace Example
{
	public interface ICombat
	{
		public int Attack { get; }

		public int Health { get; }

		public void TakeDamage(float damage);
		
		public void TakeDamage(float damage, float damageByHealthPercent);

		public bool IsAlive();
	}
}