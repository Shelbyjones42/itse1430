using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public abstract class CharacterDatabase : ICharacterRoster
    {
        public Character Add ( Character character )
        {
            if (character == null)
                throw new ArgumentNullException (nameof (character));

            var results = ObjectValidator.TryValidateObject (character);
            if (results.Count () > 0)
                throw new ValidationException (results.FirstOrDefault ().ErrorMessage);

            var existing = GetByNameCore (character.Name);
            if (existing != null)
                throw new InvalidOperationException ("Character must be unique.");

            return AddCore (character);
        }
        public Character Get ( int id )
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException (nameof (id), "Id must be greater than 0.");

            return GetCore (id);
        }
        public IEnumerable<Character> GetAll ()
            => GetAllCore () ?? Enumerable.Empty<Character> ();
        public void Remove ( int id )
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException (nameof (id), "Id must be greater than 0.");
            RemoveCore (id);
        }
        public void Update ( int id, Character newCharacter )
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException (nameof (id), "Id must be greater than 0");

            if (newCharacter == null)
                throw new ArgumentNullException (nameof (newCharacter));

            var results = ObjectValidator.TryValidateObject (newCharacter);

            if (results.Count () > 0)
                throw new ValidationException (results.FirstOrDefault ().ErrorMessage);

            var existing = GetByNameCore (newCharacter.Name);
            if (existing != null && existing.Id != id)
                throw new InvalidOperationException ("Name must be unique.");

            try
            {
                UpdateCore (id, newCharacter);
            }catch  (IOException ex)
            {
                throw new Exception ("An error occured updating the character", ex);
            };
        }

        protected abstract Character AddCore ( Character character );
        protected abstract Character GetCore ( int id );
        protected abstract IEnumerable<Character> GetAllCore ();
        protected abstract Character GetByNameCore ( string name );
        protected abstract void RemoveCore ( int id );
        protected abstract Character UpdateCore ( int id, Character newCharacter );
    }
}
