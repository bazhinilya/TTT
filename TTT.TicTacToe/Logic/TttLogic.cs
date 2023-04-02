using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using TTT.TicTacToe.Models.Context;
using TTT.TicTacToe.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace TTT.TicTacToe.Logic
{
    public class TttLogic
    {
        private readonly TttContext _context;
        public TttLogic() { }
        public TttLogic(TttContext context) => _context = context;
        public async Task<IEnumerable<PlayingField>> GetFields() => await _context.Fields.ToListAsync();
        public async Task<PlayingField> AddField(int id, bool value)
        {
            var allFields = _context.Fields;
            CheckingForCurrentMove(value, await allFields.ToListAsync());
            PlayingField fieldToCreate = new() { Id = id, Value = value };
            await _context.Fields.AddAsync(fieldToCreate);
            await _context.SaveChangesAsync();
            var sortedFields = allFields.Where(f => f.Value == value);
            if (CheckVictory(await sortedFields.ToListAsync())) throw new Exception($"Победа {value}");
            return fieldToCreate;
        }

        public async Task<IEnumerable<PlayingField>> ClearFields()
        {
            var fields = _context.Fields;
            if (fields == null) return null;
            foreach (var field in fields)
            {
                fields.Remove(field);
            }
            await _context.SaveChangesAsync();
            return await _context.Fields.ToListAsync();
        }

        private static void CheckingForCurrentMove(bool value, List<PlayingField> allFields)
        {
            var trueFields = allFields.Where(f => f.Value).ToList();
            var falseFields = allFields.Where(f => !f.Value).ToList();
            if (trueFields.Count > falseFields.Count)
            {
                if (value) throw new Exception($"Сейчас должен быть {!value}");
            }
            if (trueFields.Count == falseFields.Count)
            {
                if (!value) throw new Exception($"Сейчас должен быть {value}");
            }
        }

        public static bool CheckVictory(List<PlayingField> sortedFields)
        {
            if (sortedFields.Count < 3) return false;
            int first = 1;
            int second = 2;
            int third = 3;
            int variable = 0;
            int index = 3;
            do
            {
                if (variable == 3) { first = 1; second = 4; third = 7; index = 1; }
                if (variable == 6) { first = 1; second = 5; third = 9; index = 0; }
                if (variable == 7) { first = 3; second = 5; third = 7; index = 0; }
                var fields = sortedFields.Where(f => f.Id == first || f.Id == second || f.Id == third).ToList();
                if (fields.Count == 3) return true;
                first += index; second += index; third += index;
                variable++;
            }
            while (variable < 8);
            return false;
        }
    }
}
