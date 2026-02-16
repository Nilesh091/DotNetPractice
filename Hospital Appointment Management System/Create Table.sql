CREATE TABLE Departments
(
  DepartmentId INT PRIMARY KEY IDENTITY(1,1),
  DepartmentName NVARCHAR(100) NOT NULL,
  Location NVARCHAR(100) NOT NULL
);
CREATE TABLE Doctors
(
  DoctorId INT PRIMARY KEY IDENTITY(1,1),
  DoctorName NVARCHAR(100) NOT NULL,
  Specialization NVARCHAR(100) NOT NULL,
  DepartmentId INT NOT NULL,
  ConsultationFee DECIMAL(10,2) NOT NULL,
  CONSTRAINT FK_Doctor_Department
        FOREIGN KEY (DepartmentId)
        REFERENCES Departments(DepartmentId)
);
CREATE TABLE Patients
(
  PatientId INT PRIMARY KEY IDENTITY(1,1),
  PatientName NVARCHAR(100) NOT NULL,
  Gender NVARCHAR(10),
  DateOfBirth DATE,
  Phone NVARCHAR(15),
  Email NVARCHAR(100)
);
CREATE TABLE Appointments
(
  AppointmentId INT PRIMARY KEY IDENTITY(1,1),
  AppointmentDate DATETIME NOT NULL,
  DoctorId INT NOT NULL,
  PatientId INT NOT NULL,
  Status NVARCHAR(20) NOT NULL,
  CONSTRAINT FK_Appointment_Doctor
        FOREIGN KEY (DoctorId)
        REFERENCES Doctors(DoctorId),
  CONSTRAINT FK_Appointment_Patient
        FOREIGN KEY (PatientId)
        REFERENCES Patients(PatientId)
);
CREATE TABLE Prescriptions
(
  PrescriptionId INT PRIMARY KEY IDENTITY(1,1),
  AppointmentId INT NOT NULL,
  Diagnosis NVARCHAR(255),
  MedicineDetails NVARCHAR(MAX),
  Remarks NVARCHAR(255),
  CONSTRAINT FK_Prescription_Appointment
        FOREIGN KEY (AppointmentId)
        REFERENCES Appointments(AppointmentId)
);
