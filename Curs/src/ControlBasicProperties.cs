using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Curs.Form1;

namespace Curs.src
{
    public class ControlBasicProperties
    {
        private Dictionary<string, List<StructParsGroup>> _courseGroups = new Dictionary<string, List<StructParsGroup>>();
        private Dictionary<string, List<string>> _instructors = new Dictionary<string, List<string>>();
        private Dictionary<string, List<List<string>>> _fullSchedule = new Dictionary<string, List<List<string>>>();

        /// <summary>
        /// словарь, созданный для хранения 
        /// "Группы (ее название) : Список предметов для этой группы (название предмета : часы на предмет)"
        /// </summary>
        public Dictionary<string, List<StructParsGroup>> CourseGroups // 
        {
            get { return _courseGroups; }
            set { _courseGroups = value; }
        }

        /// <summary>
        /// словарь, созданный для хранения 
        /// "Предподаватель : список предметов, которые он ведет"
        /// </summary>
        public Dictionary<string, List<string>> Instructors 
        {
            get { return _instructors; }
            set { _instructors = value; }
        }

        /// <summary>
        /// словарь, созданный для хранения полного расписания для всех групп
        /// "Название группы : 1-й лист характеризует i день, 2-й лист само расписание на i день" (пример: Б48 : 1-й день [Математика, Физика, Русский язык])
        /// </summary>
        public Dictionary<string, List<List<string>>> FinalSchedule
        {
            get { return _fullSchedule; }
            set { _fullSchedule = value; }
        }

        // Инициализируем переменные для того, чтобы они были всегда готовы к использованию
        public ControlBasicProperties()
        {
            _courseGroups = new Dictionary<string, List<StructParsGroup>>();
            _instructors = new Dictionary<string, List<string>>();
            _fullSchedule = new Dictionary<string, List<List<string>>>();
        }
    }
}
