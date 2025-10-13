using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class HospitalDemo
    {
        public void Run()
        {
            Hospital hospital = new Hospital();

            Doctor doctor = new Doctor(1, "Олег", "Хірург");
            Doctor doctor1 = new Doctor(2, "Кімдрат", "Терепевт");
            Doctor doctor2 = new Doctor(3, "Зореслава", "Кардіолог");

            hospital.AddDoctor(doctor);
            hospital.AddDoctor(doctor1);
            hospital.AddDoctor(doctor2);

            Patient patient = new Patient(1, "Юрій", 66);
            Patient patient1 = new Patient(2, "Артур", 14);
            Patient patient2 = new Patient(3, "Віталій", 52);
            Patient patient3 = new Patient(4, "Анастасія", 5);

            hospital.RegisterPatient(patient);
            hospital.RegisterPatient(patient1);
            hospital.RegisterPatient(patient2);
            hospital.RegisterPatient(patient3);

            HospitalRoom room1 = new HospitalRoom(101, 2);
            HospitalRoom room2 = new HospitalRoom(102, 3);
            HospitalRoom room3 = new HospitalRoom(103, 1);

            hospital.CreateRoom(room1);
            hospital.CreateRoom(room2);
            hospital.CreateRoom(room3);

            hospital.HospitalizePatient(1, 102);
            hospital.HospitalizePatient(2, 101);
            hospital.HospitalizePatient(3, 101);
            hospital.HospitalizePatient(4, 103);

            MedicalRecord record = new MedicalRecord(patient, doctor2, new DateTime(2025, 10, 19), "Кардіограма");
            MedicalRecord record1 = new MedicalRecord(patient1, doctor1, new DateTime(2025, 10, 18), "Медогляд");
            MedicalRecord record2 = new MedicalRecord(patient3, doctor, new DateTime(2025, 10, 14), "Операція");
            MedicalRecord record3 = new MedicalRecord(patient2, doctor2, new DateTime(2025, 10, 25), "Кардіограма");

            hospital.AddMedicalRecord(record);
            hospital.AddMedicalRecord(record1);
            hospital.AddMedicalRecord(record2);
            hospital.AddMedicalRecord(record3);

            Console.WriteLine("\n--- ІСТОРІЯ ПАЦІЄНТА ---");
            var history = hospital.GetPatientHistory(1);
            foreach (var records in history)
            {
                Console.WriteLine($"  Дата: {record.Date.ToShortDateString()}");
                Console.WriteLine($"  Лікар: {record.Doctor.Name}");
                Console.WriteLine($"  Опис: {record.Description}\n");
            }
            Console.WriteLine(hospital.GetStatistics());
        }
    }
}
