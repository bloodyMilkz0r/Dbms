using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Runtime.CompilerServices;

namespace HospitalDB
{
    public class ViewModel : INotifyPropertyChanged
    {
        AppContext db;
        Command addCommand;
        Command editCommand;
        Command deleteCommand;
        Command printCommand;
        Command printMedHistCommand;
        Command printProtocol;
        IEnumerable<Patient> patients;

        public IEnumerable<Patient> Patients
        {
            get { return patients; }
            set
            {
                patients = value;
                PropertyChangedOn("Patients");
            }
        }

        public ViewModel()
        {
            db = new AppContext();
            db.Patients.Load();
            Patients = db.Patients.Local.ToBindingList();
        }

        public Command AddCommand
        {
            get
            {
                return addCommand ??
                    (addCommand = new Command((o) =>
                    {
                        EditWindow editWindow = new EditWindow(new Patient());
                        if (editWindow.ShowDialog() == true)
                        {
                            Patient patient = editWindow.Patient;
                            db.Patients.Add(patient);
                            db.SaveChanges();
                        }

                    }));
            }
        }

        public Command EditCommand
        {
            get
            {
                return editCommand ??
                    (editCommand = new Command((selectedItem) =>
                {
                    if (selectedItem == null) return;
                    //получаем выделенный объект
                    Patient patient = selectedItem as Patient;
                    
                    Patient vm = new Patient()
                    {
                        #region Конструктор

                        Id = patient.Id,
                        Name = patient.Name,
                        MedicalHistory = patient.MedicalHistory,
                        Data = patient.Data,
                        StartTime = patient.StartTime,
                        FinishTime = patient.FinishTime,
                        Department = patient.Department,
                        TypeOfIntervention = patient.TypeOfIntervention,
                        TypeOfService = patient.TypeOfService,
                        Sequela = patient.Sequela,
                        MedicalCare = patient.MedicalCare, 
                        PriceOfService = patient.PriceOfService,
                        Price = patient.Price,
                        Code = patient.Code,
                        NameDoctor = patient.NameDoctor,
                        NameNurse = patient.NameNurse,
                        Premedication = patient.Premedication,
                        PremedicationQuantity = patient.PremedicationQuantity,
                        Opioids = patient.Opioids,
                        OpioidsQuantity = patient.OpioidsQuantity,
                        Benzodiazepine = patient.Benzodiazepine,
                        BenzodiazepineQuantity = patient.BenzodiazepineQuantity,
                        Hypnotic = patient.Hypnotic,
                        HypnoticQuantity = patient.Hypnotic,
                        MuscleRelaxant = patient.MuscleRelaxant,
                        MuscleRelaxantQuantity = patient.MuscleRelaxantQuantity,
                        FluorideContaining = patient.FluorideContaining,
                        FluorideContainingQuantity = patient.FluorideContainingQuantity,
                        Inhalation = patient.Inhalation,
                        TimeInhalation = patient.TimeInhalation,
                        InhalationQuantity = patient.InhalationQuantity,
                        Opioids2 = patient.Opioids2,
                        Opioids2Quantity = patient.Opioids2Quantity,
                        Local = patient.Local,
                        LocalQuantity = patient.LocalQuantity,
                        Local2 = patient.Local2,
                        Local2Quantity = patient.Local2Quantity,
                        Neurovegetative = patient.Neurovegetative,
                        NeurovegetativeQuantity = patient.NeurovegetativeQuantity,
                        Hemostatics = patient.Hemostatics,
                        HemostaticsQuantity = patient.Hemostatics,
                        Antispasmodics = patient.Antispasmodics,
                        AntispasmodicsQuantity = patient.AntispasmodicsQuantity,
                        Solutions = patient.Solutions,
                        SolutionsQuantity = patient.SolutionsQuantity,
                        Antropine = patient.Antropine,
                        AntropineQuantity = patient.AntropineQuantity,
                        EpudralKit = patient.EpudralKit,
                        SpialNeedle = patient.SpialNeedle,
                        TypeOfSpialNeedle = patient.TypeOfSpialNeedle,
                        EndotrachealTube = patient.EndotrachealTube,
                        Points = patient.Points

        #endregion
                    };
                    // передаем выделенный объект в диалог окно
                    EditWindow editWindow = new EditWindow(vm);

                    if (editWindow.ShowDialog() == true)
                    {
                        //получаем изменнеый объект
                        patient = db.Patients.Find(editWindow.Patient.Id);
                        if(patient != null)
                        {
                            #region присвоение


                            patient.Name = editWindow.Patient.Name;
                            patient.MedicalHistory = editWindow.Patient.MedicalHistory;
                            patient.Data = editWindow.Patient.Data;
                            patient.StartTime = editWindow.Patient.StartTime;
                            patient.FinishTime = editWindow.Patient.FinishTime;
                            patient.Department = editWindow.Patient.Department;
                            patient.TypeOfIntervention = editWindow.Patient.TypeOfIntervention;
                            patient.TypeOfService = editWindow.Patient.TypeOfService;
                            patient.Sequela = editWindow.Patient.Sequela;
                            patient.MedicalCare = editWindow.Patient.MedicalCare;
                            patient.PriceOfService = editWindow.Patient.PriceOfService;
                            patient.Price = editWindow.Patient.Price;
                            patient.Code = editWindow.Patient.Code;
                            patient.NameDoctor = editWindow.Patient.NameDoctor;
                            patient.NameNurse = editWindow.Patient.NameNurse;
                            patient.Premedication = editWindow.Patient.Premedication;
                            patient.PremedicationQuantity = editWindow.Patient.PremedicationQuantity;
                            patient.Opioids = editWindow.Patient.Opioids;
                            patient.OpioidsQuantity = editWindow.Patient.OpioidsQuantity;
                            patient.Benzodiazepine = editWindow.Patient.Benzodiazepine;
                            patient.BenzodiazepineQuantity = editWindow.Patient.BenzodiazepineQuantity;
                            patient.Hypnotic = editWindow.Patient.Hypnotic;
                            patient.HypnoticQuantity = editWindow.Patient.HypnoticQuantity;
                            patient.MuscleRelaxant = editWindow.Patient.MuscleRelaxant;
                            patient.MuscleRelaxantQuantity = editWindow.Patient.MuscleRelaxantQuantity;
                            patient.FluorideContaining = editWindow.Patient.FluorideContaining;
                            patient.FluorideContainingQuantity = editWindow.Patient.FluorideContainingQuantity;
                            patient.Inhalation = editWindow.Patient.Inhalation;
                            patient.TimeInhalation = editWindow.Patient.TimeInhalation;
                            patient.InhalationQuantity = editWindow.Patient.InhalationQuantity;
                            patient.Opioids2 = editWindow.Patient.Opioids2;
                            patient.Opioids2Quantity = editWindow.Patient.Opioids2Quantity;
                            patient.Local = editWindow.Patient.Local;
                            patient.LocalQuantity = editWindow.Patient.LocalQuantity;
                            patient.Local2 = editWindow.Patient.Local2;
                            patient.Local2Quantity = editWindow.Patient.Local2Quantity;
                            patient.Neurovegetative = editWindow.Patient.Neurovegetative;
                            patient.NeurovegetativeQuantity = editWindow.Patient.NeurovegetativeQuantity;
                            patient.Hemostatics = editWindow.Patient.Hemostatics;
                            patient.HemostaticsQuantity = editWindow.Patient.HemostaticsQuantity;
                            patient.Antispasmodics = editWindow.Patient.Antispasmodics;
                            patient.AntispasmodicsQuantity = editWindow.Patient.AntispasmodicsQuantity;
                            patient.Solutions = editWindow.Patient.Solutions;
                            patient.SolutionsQuantity = editWindow.Patient.SolutionsQuantity;
                            patient.Antropine = editWindow.Patient.Antropine;
                            patient.AntropineQuantity = editWindow.Patient.AntropineQuantity;
                            patient.EpudralKit = editWindow.Patient.EpudralKit;
                            patient.SpialNeedle = editWindow.Patient.SpialNeedle;
                            patient.TypeOfSpialNeedle = editWindow.Patient.TypeOfSpialNeedle;
                            patient.EndotrachealTube = editWindow.Patient.EndotrachealTube;
                            patient.Points = editWindow.Patient.Points;
                            #endregion
                            db.Entry(patient).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }
                }));
            }
        } 

        public Command DeleteCommand
        {
            get
            {
                return deleteCommand ??
                    (deleteCommand = new Command((selectedItem) =>
                    {
                        if (selectedItem == null) return;
                        Patient patient = selectedItem as Patient;
                        db.Patients.Remove(patient);
                        db.SaveChanges();
                    }));
            }
        }


        public Command PrintDoc
        {
            get
            {
                return printCommand ??
                    (printCommand = new Command((selectedItem) =>
                    {
                        if (selectedItem == null) return;
                        //получаем выделенный объект
                        Patient patient = selectedItem as Patient;

                        Patient vm = new Patient()
                        {
                            #region Конструктор

                            Id = patient.Id,
                            Name = patient.Name,
                            MedicalHistory = patient.MedicalHistory,
                            Data = patient.Data,
                            StartTime = patient.StartTime,
                            FinishTime = patient.FinishTime,
                            Department = patient.Department,
                            TypeOfIntervention = patient.TypeOfIntervention,
                            TypeOfService = patient.TypeOfService,
                            Sequela = patient.Sequela,
                            MedicalCare = patient.MedicalCare,
                            PriceOfService = patient.PriceOfService,
                            Price = patient.Price,
                            Code = patient.Code,
                            NameDoctor = patient.NameDoctor,
                            NameNurse = patient.NameNurse,
                            Premedication = patient.Premedication,
                            PremedicationQuantity = patient.PremedicationQuantity,
                            Opioids = patient.Opioids,
                            OpioidsQuantity = patient.OpioidsQuantity,
                            Benzodiazepine = patient.Benzodiazepine,
                            BenzodiazepineQuantity = patient.BenzodiazepineQuantity,
                            Hypnotic = patient.Hypnotic,
                            HypnoticQuantity = patient.Hypnotic,
                            MuscleRelaxant = patient.MuscleRelaxant,
                            MuscleRelaxantQuantity = patient.MuscleRelaxantQuantity,
                            FluorideContaining = patient.FluorideContaining,
                            FluorideContainingQuantity = patient.FluorideContainingQuantity,
                            Inhalation = patient.Inhalation,
                            TimeInhalation = patient.TimeInhalation,
                            InhalationQuantity = patient.InhalationQuantity,
                            Opioids2 = patient.Opioids2,
                            Opioids2Quantity = patient.Opioids2Quantity,
                            Local = patient.Local,
                            LocalQuantity = patient.LocalQuantity,
                            Local2 = patient.Local2,
                            Local2Quantity = patient.Local2Quantity,
                            Neurovegetative = patient.Neurovegetative,
                            NeurovegetativeQuantity = patient.NeurovegetativeQuantity,
                            Hemostatics = patient.Hemostatics,
                            HemostaticsQuantity = patient.Hemostatics,
                            Antispasmodics = patient.Antispasmodics,
                            AntispasmodicsQuantity = patient.AntispasmodicsQuantity,
                            Solutions = patient.Solutions,
                            SolutionsQuantity = patient.SolutionsQuantity,
                            Antropine = patient.Antropine,
                            AntropineQuantity = patient.AntropineQuantity,
                            EpudralKit = patient.EpudralKit,
                            SpialNeedle = patient.SpialNeedle,
                            TypeOfSpialNeedle = patient.TypeOfSpialNeedle,
                            EndotrachealTube = patient.EndotrachealTube,
                            Points = patient.Points

                            #endregion
                        };
                        // передаем выделенный объект в диалог окно
                        PrintDoc PrintDoc = new PrintDoc(vm);
                        PrintDoc.ShowDialog();

                    }));
            }
        }


        public Command PrinMedicalHistory
        {
            get
            {
                return printMedHistCommand ??
                    (printMedHistCommand = new Command((selectedItem) =>
                    {
                        if (selectedItem == null) return;
                        //получаем выделенный объект
                        Patient patient = selectedItem as Patient;

                        Patient vm = new Patient()
                        {
                            #region Конструктор

                            Id = patient.Id,
                            Name = patient.Name,
                            MedicalHistory = patient.MedicalHistory,
                            Data = patient.Data,
                            StartTime = patient.StartTime,
                            FinishTime = patient.FinishTime,
                            NameDoctor = patient.NameDoctor,
                            NameNurse = patient.NameNurse,

                            #endregion
                        };
                        // передаем выделенный объект в диалог окно
                        PrintMedicalHistory PrintMedicalHistory = new PrintMedicalHistory(vm);
                        PrintMedicalHistory.ShowDialog();

                    }));
            }
        }


        public Command PrintProtocol
        {
            get
            {
                return printProtocol ??
                    (printProtocol = new Command((selectedItem) =>
                    {
                        if (selectedItem == null) return;
                        //получаем выделенный объект
                        Patient patient = selectedItem as Patient;

                        Patient vm = new Patient()
                        {
                            #region Конструктор

                            Id = patient.Id,
                            Name = patient.Name,
                            MedicalHistory = patient.MedicalHistory,
                            Data = patient.Data,
                            StartTime = patient.StartTime,
                            FinishTime = patient.FinishTime,
                            NameDoctor = patient.NameDoctor,
                            NameNurse = patient.NameNurse,

                            #endregion
                        };
                        // передаем выделенный объект в диалог окно
                        PrintProtocol PrintProtocol = new PrintProtocol(vm);
                        PrintProtocol.ShowDialog();

                    }));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void PropertyChangedOn([CallerMemberName]string property = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

    }
}
