
using Flunt.Notifications;

namespace PaymentContext.Shared.Entities
{
    public abstract class Entity : Notifiable<Notification>
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; } // Guid gera o ID no .NET e não no banco. Ele é menos performático, mas não depende do banco, deixando menos Request do banco.
    }
}