using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Bodis_Bianca_Proiect.Data;

namespace Bodis_Bianca_Proiect.Models
{
    public class AnimalTraitsPageModel : PageModel
    {
        public List<AssignedTraitData> AssignedTraitDataList;
        public void PopulateAssignedTraitData(Bodis_Bianca_ProiectContext context, Animal animal)
        {
            var allTraits = context.Trait;
            var animalTraits = new HashSet<int>(
            animal.AnimalTraits.Select(c => c.AnimalID));
            AssignedTraitDataList = new List<AssignedTraitData>();
            foreach (var cat in allTraits)
            {
                AssignedTraitDataList.Add(new AssignedTraitData
                {
                    TraitID = cat.ID,
                    Name = cat.TraitName,
                    Assigned = animalTraits.Contains(cat.ID)
                });
            }
        }
        public void UpdateAnimalTraits(Bodis_Bianca_ProiectContext context, string[] selectedTraits, Animal animalToUpdate)
        {
            if (selectedTraits == null)
            {
                animalToUpdate.AnimalTraits = new List<AnimalTrait>();
                return;
            }
            var selectedTraitsHS = new HashSet<string>(selectedTraits);
            var animalTraits = new HashSet<int>
            (animalToUpdate.AnimalTraits.Select(c => c.Trait.ID));
            foreach (var cat in context.Trait)
            {
                if (selectedTraitsHS.Contains(cat.ID.ToString()))
                {
                    if (!animalTraits.Contains(cat.ID))
                    {
                        animalToUpdate.AnimalTraits.Add(
                        new AnimalTrait
                        {
                            AnimalID = animalToUpdate.ID,
                            TraitID = cat.ID
                        });
                    }
                }
                else
                {
                    if (animalTraits.Contains(cat.ID))
                    {
                        AnimalTrait traitToRemove
                        = animalToUpdate
                        .AnimalTraits
                        .SingleOrDefault(i => i.TraitID == cat.ID);
                        context.Remove(traitToRemove);
                    }
                }
            }
        }
    }
}
