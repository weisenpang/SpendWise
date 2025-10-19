CREATE DATABASE IF NOT EXISTS vbprojectdbfinal;
USE vbprojectdbfinal;


CREATE TABLE IF NOT EXISTS users (
    uid INT(11) NOT NULL AUTO_INCREMENT,
    username VARCHAR(50) NOT NULL,
    password_hash VARCHAR(255) NOT NULL,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY (uid),
    UNIQUE KEY (username)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;


CREATE TABLE IF NOT EXISTS admin (
    adminID INT(20) NOT NULL AUTO_INCREMENT,
    adminUsername VARCHAR(50) NOT NULL,
    adminPassword VARCHAR(50) NOT NULL,
    PRIMARY KEY (adminID),
    UNIQUE KEY (adminUsername)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;


CREATE TABLE IF NOT EXISTS balance (
    uid INT(11) NOT NULL,
    currentBalance DECIMAL(10,2) NOT NULL DEFAULT 0.00,
    lastUpdated TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    PRIMARY KEY (uid),
    FOREIGN KEY (uid) REFERENCES users(uid) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;


CREATE TABLE IF NOT EXISTS transactions (
    transactionID INT(11) NOT NULL AUTO_INCREMENT,
    uid INT(11) NOT NULL,
    description VARCHAR(255) NOT NULL,
    amount DECIMAL(10,2) NOT NULL,
    category VARCHAR(50) NOT NULL,
    transactionDate DATE NOT NULL,
    type ENUM('Income', 'Expense') NOT NULL,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY (transactionID),
    FOREIGN KEY (uid) REFERENCES users(uid) ON DELETE CASCADE ON UPDATE CASCADE,
    INDEX idx_transaction_date (transactionDate),
    INDEX idx_user_amount (uid, amount)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;


INSERT IGNORE INTO admin (adminUsername, adminPassword) 
VALUES ('adminSpendWise', 'admin123#');


SHOW TABLES;
