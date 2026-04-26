--WILL MODIFY LATER 
-- Factions
INSERT INTO Factions VALUES ('Neon Syndicate', '⚡', 0)
INSERT INTO Factions VALUES ('Void Protocol', '☠', 0)

-- Admin
INSERT INTO Users (Codename, FullName, Email, PasswordHash, Role, FactionID)
VALUES ('CIPHER_ROOT', 'Admin', 'admin@cipher.io', 
        '$2a$11$PLACEHOLDER', 'Admin', 1)

-- 2 test agents
INSERT INTO Users (Codename, FullName, Email, PasswordHash, FactionID)
VALUES ('GHOST_X', 'Test Agent 1', 'ghost@cipher.io', '$2a$11$PLACEHOLDER', 1)
INSERT INTO Users (Codename, FullName, Email, PasswordHash, FactionID)
VALUES ('VOID_NULL', 'Test Agent 2', 'void@cipher.io', '$2a$11$PLACEHOLDER', 2)

-- 5 seeded missions
INSERT INTO Missions VALUES 
('Operation CAESAR', 'Crypto', 'Easy', 
 'Intercept decrypted. Encoded with a shift of 3. Decode: KHOOR ZRUOG', 
 'HELLO WORLD', 'Shift each letter back by 3', 50, 25, 1),
('Binary Ghost', 'Binary', 'Easy',
 'Signal captured in binary. Translate: 01000011 01001001 01010000 01001000 01000101 01010010',
 'CIPHER', 'Convert each 8-bit group to ASCII', 75, 35, 2),
('Pattern Zero', 'Logic', 'Medium',
 'The sequence: 2, 6, 18, 54, ___. What comes next?',
 '162', 'Each number is multiplied by 3', 100, 50, 3),
('Deep Frequency', 'Crypto', 'Medium',
 'ROT13 encoded transmission: FBYIR ZR VS LBH PNA',
 'SOLVE ME IF YOU CAN', 'ROT13: shift each letter by 13', 100, 50, 4),
('Neural Lock', 'Logic', 'Hard',
 'I speak without a mouth. I hear without ears. I have no body but come alive with the wind. What am I?',
 'ECHO', 'Think about sound and nature', 150, 75, 5)

 -- Bounty 1: Posted by GHOST_X, unsolved (Open)
INSERT INTO Bounties (CreatorID, SolverID, Title, EncryptedMessage, Answer, CoinReward, Status)
VALUES (2, NULL, 
        'Ghost Signal', 
        'Decode this transmission: 01001000 01000001 01000011 01001011',
        'HACK',
        40, 'Open')

-- Bounty 2: Posted by VOID_NULL, unsolved (Open)
INSERT INTO Bounties (CreatorID, SolverID, Title, EncryptedMessage, Answer, CoinReward, Status)
VALUES (3, NULL,
        'Void Cipher',
        'Caesar shift 7: AOPZA PZ ZLJYLA',
        'THIS IS SECRET',
        60, 'Open')

-- Bounty 3: Posted by GHOST_X, solved by VOID_NULL
INSERT INTO Bounties (CreatorID, SolverID, Title, EncryptedMessage, Answer, CoinReward, Status, SolvedAt)
VALUES (2, 3,
        'Neon Protocol',
        'ROT13: Gur cnffjbeq vf ARBA',
        'THE PASSWORD IS NEON',
        50, 'Solved', GETDATE())