namespace GestioneSagre.Shared.Interfaces;

public interface IEntity<TKey>
{
    TKey Id { get; set; }
}