using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    class TodoModel
    {
        private bool _isDone;
        private string _text;
        private string _name;

        [JsonProperty(PropertyName = "name")]
        public string Name 
        {
            get { return _name; }
            set
            {
                if (_name == value)
                    return;

                _name = value;
            }
        }

        [JsonProperty(PropertyName = "creationData")]
        public DateTime CreationData { get; set; } = DateTime.Now;


        [JsonProperty(PropertyName = "isDone")]
        public bool IsDone
        {
            get { return _isDone; }
            set
            {
                if (_isDone == value)
                    return;

                _isDone = value;
            }
        }

        [JsonProperty(PropertyName = "notepad")]
        public string Notepad
        {
            get { return _text; }
            set
            {
                if (_text == value)
                    return;

                _text = value;
            }
        }

    }
}
