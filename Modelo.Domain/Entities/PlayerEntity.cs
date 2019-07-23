using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    class PlayerEntity : BaseEntity
    {
        public string Name_player { get; set; }
        public string Gender { get; set; }
        public DateTime Birthdate { get; set; }
        public int CharacterId { get; set; }
        public List<CharacterEntity> CharacterEntities { get; set; }

    }
}
