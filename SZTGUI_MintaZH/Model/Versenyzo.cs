using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTGUI_MintaZH.Model
{
    public class Versenyzo : ObservableObject
    {
        private int versenyzoId;
        private int szuletesiEv;
        private string nev;
        private int futamSzam;
        private int varhatoHelyezes;
        private bool eltiltva;

        public int VersenyzoId { get => versenyzoId; set => SetProperty(ref versenyzoId, value); }

        public int SzuletesiEv { get => szuletesiEv; set => SetProperty(ref szuletesiEv, value); }

        public string Nev { get => nev; set => SetProperty(ref nev, value); }

        public int FutamSzam { get => futamSzam; set => SetProperty(ref futamSzam, value); }

        public int VarhatoHelyezes { get => varhatoHelyezes; set => SetProperty(ref varhatoHelyezes, value); }

        public bool Eltiltva { get => eltiltva; set => SetProperty(ref eltiltva, value); }

        public void CopyFrom(Versenyzo other)
        {
            this.VersenyzoId = other.VersenyzoId;
            this.SzuletesiEv = other.SzuletesiEv;
            this.Nev = other.Nev;
            this.FutamSzam = other.FutamSzam;
            this.VarhatoHelyezes = other.VarhatoHelyezes;
            this.Eltiltva = other.Eltiltva;
        }

    }
}
