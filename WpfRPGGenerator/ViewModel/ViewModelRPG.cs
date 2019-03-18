using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfRPGGenerator.Model;
namespace WpfRPGGenerator.ViewModel
{
    class ViewModelRPG : ViewModelBase
    {
        RPG rpg;
        public string Name
        {
            get { return this.rpg.Name; }
            set
            {
                RaisedPropertyChanged();
                this.rpg.Name = value;
            }
        }

        public int Strength
        {
            get { return this.rpg.Strength; }
            set
            {
                RaisedPropertyChanged();
                this.rpg.Strength = value;
            }
        }

        public int Dexterity
        {
            get { return this.rpg.Dexterity; }
            set
            {
                RaisedPropertyChanged();
                this.rpg.Dexterity = value;
            }
        }

        public int Constitution
        {
            get { return this.rpg.Constitution; }
            set
            {
                RaisedPropertyChanged();
                this.rpg.Constitution = value;
            }
        }

        public int Intelligence
        {
            get { return this.rpg.Intelligence; }
            set
            {
                RaisedPropertyChanged();
                this.rpg.Intelligence = value;
            }
        }

        public int Wisdom
        {
            get { return this.rpg.Wisdom; }
            set
            {
                RaisedPropertyChanged();
                this.rpg.Wisdom = value;
            }
        }

        public int Charisma
        {
            get { return this.rpg.Charisma; }
            set
            {
                RaisedPropertyChanged();
                this.rpg.Charisma = value;
            }
        }

        public ViewModelRPG(RPG rpg)
        {
            this.rpg = rpg;
        }
    }
}
