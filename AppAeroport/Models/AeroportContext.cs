using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAeroport.Models
{
    public class AeroportContext : DbContext
    {
        public DbSet<Aeroport> Aeroporturi { get; set; }
        public DbSet<Pasager> Pasageri { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = aeroport.db");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pasager>().HasKey(c => c.CodPasager);
            modelBuilder.Entity<Aeroport>().HasKey(c => c.CodRuta);
            modelBuilder.Entity<Aeroport>()
                .HasOne(c => c.Pasager)
                .WithMany()
                .HasForeignKey(c => c.CodPasager);
        }

        public ObservableCollection<Pasager> GetPasager()
        {
            var pasager = Pasageri.ToList();
            var pasageriObservable = new ObservableCollection<Pasager>(pasager);
            return pasageriObservable;
        }
        public void AdaugaPasager(Pasager pasager)
        {
            Pasageri.Add(pasager);
            SaveChanges();
        }
        public void ActualizeazaPasager(Pasager pasager)
        {
            Pasageri.Entry(pasager).State = EntityState.Modified;
            SaveChanges();
        }
        public void StergePasager(Pasager pasager)
        {
            Pasageri.Remove(pasager);
            SaveChanges();
        }


        public ObservableCollection<Aeroport> GetAeroport()
        {
            var aeropoarte = Aeroporturi.ToList();
            var aeropoarteObservable = new ObservableCollection<Aeroport>(aeropoarte);
            return aeropoarteObservable;
        }

        public void AdaugaRuta(Aeroport aeroport)
        {
            Aeroporturi.Add(aeroport);
            SaveChanges();
        }
        public void ActualizeazaRuta(Aeroport aeroport)
        {
            Aeroporturi.Entry(aeroport).State = EntityState.Modified;
            SaveChanges();
        }

        public void StergeRuta(Aeroport aeroport)
        {
            Aeroporturi.Remove(aeroport);
            SaveChanges();
        }


        //afiseaza pasagerii cu destinatia spre Paris si clasa 1
        public List<Aeroport> GetListaPasagDestinClasa()
        {
            List<Aeroport> pasagDestinClasa = (from aero in Aeroporturi
                                                       where aero.Destinatia == "Paris" && aero.Clasa == 1
                                                       select aero).ToList();
            return pasagDestinClasa;
        }

        //afiseaza destinatiile cu pretul intre 800 si 1200 euro
        public List<Aeroport> GetListaDestinatii800and1200euro()
        {
            List<Aeroport> destinatii800and1200euro = (from aerop in Aeroporturi
                                               where aerop.Pret >= 800 && aerop.Pret <= 1200
                                               select aerop).ToList();
            return destinatii800and1200euro;
        }

        //afiseaza destinatiile disponibile si suma incasata de la pasageri
        public List<SumaIncasata> GetListaDestinatiiSumaIncasata()
        {
            List<SumaIncasata> destinatiiSumaIncasata = (from aer in Aeroporturi
                                                         group aer by aer.Destinatia into a
                                                         select new SumaIncasata { Destinatie = a.Key, Suma = (int)a.Sum(a => a.Pret) }).ToList();
            return destinatiiSumaIncasata;

            //var destinatiiSumaIncasata = Aeroporturi
            //   .GroupBy(c => c.Destinatia)
            //   .Select(g => new SumaIncasata
            //   {
            //       Destinatie = g.Key,
            //       Suma = g.Sum(c => c.Pret)
            //   });

            //List<SumaIncasata> result = destinatiiSumaIncasata.ToList();
            //return result;
        }
    }
}
