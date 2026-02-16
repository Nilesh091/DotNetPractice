INSERT INTO Departments
  (DepartmentName, Location)
VALUES
  ('Cardiology', 'Block A'),
  ('Orthopedics', 'Block B'),
  ('Neurology', 'Block C');

INSERT INTO Doctors
  (DoctorName, Specialization, DepartmentId, ConsultationFee)
VALUES
  ('Dr. Rajesh Kumar', 'Heart Specialist', 1, 800),
  ('Dr. Meena Sharma', 'Bone Specialist', 2, 600),
  ('Dr. Arvind Rao', 'Neuro Surgeon', 3, 1000);

INSERT INTO Patients
  (PatientName, Gender, DateOfBirth, Phone, Email)
VALUES
  ('Ravi Kumar', 'Male', '1990-05-12', '9876543210', 'ravi@gmail.com'),
  ('Anita Singh', 'Female', '1988-03-20', '9876501234', 'anita@gmail.com');

INSERT INTO Appointments
  (AppointmentDate, DoctorId, PatientId, Status)
VALUES
  (GETDATE(), 1, 1, 'Scheduled'),
  (GETDATE(), 2, 2, 'Completed');

INSERT INTO Prescriptions
  (AppointmentId, Diagnosis, MedicineDetails, Remarks)
VALUES
  (2, 'Minor Fracture', 'Calcium Tablets, Painkiller', 'Review after 15 days');
