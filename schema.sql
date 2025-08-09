/* ==== CREATE TABLES ==== */

CREATE TABLE Clients (
  "Client Id" INTEGER PRIMARY KEY,
  "Name" TEXT,
  "email/number" TEXT,
  "Last Margin" REAL,
  "client folder id" TEXT,
  "adress" TEXT
);

CREATE TABLE Job (
  "Job #" INTEGER PRIMARY KEY,
  "Client Id" INTEGER,
  "Costing Sheet Id" INTEGER,
  "Status" TEXT,
  "Drive Folder Id" TEXT,
  "Description" TEXT
);

CREATE TABLE Costing Sheets (
  "Sheet Id" INTEGER PRIMARY KEY,
  "Job #" INTEGER,
  "date" TEXT,
  "quote amount" REAL,
  "margin" REAL,
  "client" TEXT
);

CREATE TABLE Line Items (
  "Line Item Id" INTEGER PRIMARY KEY,
  "Job #" INTEGER,
  "Item name" TEXT,
  "Quantity" INTEGER,
  "Price" REAL
);

/* ==== ADD FOREIGN KEYS ==== */

ALTER TABLE Job
ADD CONSTRAINT fk_Job_Clients_Client Id
FOREIGN KEY ("Client Id") REFERENCES Clients("Client Id");

ALTER TABLE Job
ADD CONSTRAINT fk_Job_Costing Sheets_Costing Sheet Id
FOREIGN KEY ("Costing Sheet Id") REFERENCES Costing Sheets("Sheet Id");

ALTER TABLE Costing Sheets
ADD CONSTRAINT fk_Costing Sheets_Job_Job #
FOREIGN KEY ("Job #") REFERENCES Job("Job #");

ALTER TABLE Line Items
ADD CONSTRAINT fk_Line Items_Job_Job #
FOREIGN KEY ("Job #") REFERENCES Job("Job #");