-- Assignment --
DROP TABLE Assignment;
ALTER SESSION SET NLS_DATE_FORMAT = 'YYYY-MM-DD';
CREATE TABLE Assignment
(
    coach_id    NUMBER(4) NOT NULL,
    player_id    NUMBER(4) NOT NULL
);

CREATE UNIQUE INDEX Assignment_PK ON Assignment
( coach_id,player_id );

ALTER TABLE Assignment
 ADD CONSTRAINT Assignment_PK PRIMARY KEY ( coach_id,player_id )
 USING INDEX Assignment_PK;

-- Coach --
DROP TABLE Coach;

CREATE TABLE Coach
(
    coach_id    NUMBER(4) NOT NULL,
    coach_position    VARCHAR2(4)
);

CREATE UNIQUE INDEX Coach_PK ON Coach
( coach_id );

ALTER TABLE Coach
 ADD CONSTRAINT Coach_PK PRIMARY KEY ( coach_id )
 USING INDEX Coach_PK;

-- Injure --
DROP TABLE Injure;

CREATE TABLE Injure
(
    player_id    NUMBER(4) NOT NULL,
    injury_name    VARCHAR2(20),
    injury_date    DATE,
    injury_duration    DATE
);

CREATE UNIQUE INDEX Injure_PK ON Injure
( player_id );

ALTER TABLE Injure
 ADD CONSTRAINT Injure_PK PRIMARY KEY ( player_id )
 USING INDEX Injure_PK;

-- JobCode --
DROP TABLE JobCode;

CREATE TABLE JobCode
(
    job_code    NUMBER(4) NOT NULL,
    description    VARCHAR2(10)
);

CREATE UNIQUE INDEX JobCode_PK ON JobCode
( job_code );

ALTER TABLE JobCode
 ADD CONSTRAINT JobCode_PK PRIMARY KEY ( job_code )
 USING INDEX JobCode_PK;

insert into JobCode values(1,'player');
insert into JobCode values(2,'head coach');
insert into JobCode values(3,'coach');

-- League_Team --
DROP TABLE League_Team;

CREATE TABLE League_Team
(
    team_name VARCHAR2(20) NOT NULL,
    league_ranking NUMBER(3),
    points_won NUMBER(3),
    total_goals_scored  NUMBER(3),
    total_goals_conceded  NUMBER(3)
);

insert into League_Team values('SeoulFC', 1, 71, 100, 50);

CREATE UNIQUE INDEX League_Team_PK ON League_Team
( team_name );

ALTER TABLE League_Team
 ADD CONSTRAINT League_Team_PK PRIMARY KEY ( team_name )
 USING INDEX League_Team_PK;

-- Manager --
DROP TABLE Manager;

CREATE TABLE Manager
(
    manager_id    NUMBER(4) NOT NULL,
    preferred_tactic    VARCHAR2(10),
    mprevious_team    VARCHAR2(20)
);

CREATE UNIQUE INDEX Manager_PK ON Manager
( manager_id );

ALTER TABLE Manager
 ADD CONSTRAINT Manager_PK PRIMARY KEY ( manager_id )
 USING INDEX Manager_PK;

-- Match --
DROP TABLE Match;

CREATE TABLE Match
(
    match_code    NUMBER(6) NOT NULL,
    opponent_team_name    VARCHAR2(20) NOT NULL,
    manager_id    NUMBER(4) NOT NULL,
    goals_scored_in_the_match    NUMBER(2),
    goals_conceded_in_the_match    NUMBER(2),
    total_effective_shots    NUMBER(2),
    total_number_of_yellow_cards    NUMBER(2),
    total_number_of_red_cards    NUMBER(2),
    weather_on_the_match_day    VARCHAR2(10)
);

CREATE UNIQUE INDEX Match_PK ON Match
( match_code );

ALTER TABLE Match
 ADD CONSTRAINT Match_PK PRIMARY KEY ( match_code )
 USING INDEX Match_PK;

INSERT INTO match values(1,'1',1,1,1,1,1,1,'1');

-- MatchSchedule --
DROP TABLE MatchSchedule;

CREATE TABLE MatchSchedule
(
    match_code    NUMBER(6) NOT NULL,
    match_date    DATE,
    match_progress_status    NUMBER(1)
);

CREATE UNIQUE INDEX MatchSchedule_PK ON MatchSchedule
( match_code );

ALTER TABLE MatchSchedule
 ADD CONSTRAINT MatchSchedule_PK PRIMARY KEY ( match_code )
 USING INDEX MatchSchedule_PK;

INSERT INTO MatchSchedule values(1,'2022/11/11',1);

-- Personal --
DROP TABLE Personal;

CREATE TABLE Personal
(
    personal_id    NUMBER(4) NOT NULL,
    name    VARCHAR2(40),
    age    NUMBER(2),
    nationality    VARCHAR2(20),
    contract_date    DATE,
    contract_duration    DATE,
    transfer_fee    NUMBER(9),
    salary    NUMBER(9),
    job_code    NUMBER(4) NOT NULL
);

CREATE UNIQUE INDEX Personal_PK ON Personal
( personal_id );

ALTER TABLE Personal
 ADD CONSTRAINT Personal_PK PRIMARY KEY ( personal_id )
 USING INDEX Personal_PK;

insert into Personal values(0, 'Lee JaeHyeok', 42, 'Korea', '2023/11/23', '2025/11/23',5000 ,259 ,2);
insert into Personal values(1, 'Hong GilDong', 22, 'Korea', '2023/11/23', '2025/11/23',5000 ,259 ,3);
insert into Personal values(2, 'Son HeungMin', 28, 'Korea', '2023/11/23', '2025/11/23',5000 ,259 ,1);

-- Player --
DROP TABLE Player;

CREATE TABLE Player
(
    player_id    NUMBER(4) NOT NULL,
    uniform_number    NUMBER(2),
    position    VARCHAR2(4),
    main_foot    NUMBER(1),
    pprevious_team    VARCHAR2(20)
);

CREATE UNIQUE INDEX Player_PK ON Player
( player_id );

ALTER TABLE Player
 ADD CONSTRAINT Player_PK PRIMARY KEY ( player_id )
 USING INDEX Player_PK;

-- PlayerInGame --
DROP TABLE PlayerInGame;

CREATE TABLE PlayerInGame
(
    match_code    NUMBER(6) NOT NULL,
    player_id    NUMBER(4) NOT NULL,
    position    VARCHAR2(3),
    goal_scored    NUMBER(2),
    assists    NUMBER(2),
    total_shots    NUMBER(2),
    effective_shots    NUMBER(2),
    player_rating    NUMBER(2),
    substitution_time    TIMESTAMP,
    playing_time    TIMESTAMP,
    yellow_cards    NUMBER(1),
    red_card    NUMBER(1)
);

CREATE UNIQUE INDEX PlayerInGame_PK ON PlayerInGame
( player_id,match_code );

ALTER TABLE PlayerInGame
 ADD CONSTRAINT PlayerInGame_PK PRIMARY KEY ( player_id,match_code )
 USING INDEX PlayerInGame_PK;

Insert INTO PlayerInGame values(1,1,'FW',1,1,1,1,1,'','',1,1);
-- Staff --
DROP TABLE Staff;

CREATE TABLE Staff
(
    staff_id    NUMBER(4) NOT NULL,
    task    VARCHAR2(20)
);

CREATE UNIQUE INDEX Staff_PK ON Staff
( staff_id );

ALTER TABLE Staff
 ADD CONSTRAINT Staff_PK PRIMARY KEY ( staff_id )
 USING INDEX Staff_PK;

-- Financial --
DROP SEQUENCE FIN_SEQ;
CREATE SEQUENCE FIN_SEQ
INCREMENT BY 1
START WITH 1
MAXVALUE 9999
NOCYCLE;

DROP TABLE Financial;

CREATE TABLE Financial
(
    finno    NUMBER(4) NOT NULL,
    flowdate    DATE,
    reason    VARCHAR2(20),
    ftype    NUMBER(1),
    amount    NUMBER(10)
);

COMMENT ON COLUMN Financial.flowdate IS '날짜';

COMMENT ON COLUMN Financial.reason IS '명분';

COMMENT ON COLUMN Financial.ftype IS '거래유형';

COMMENT ON COLUMN Financial.amount IS '금액';

COMMENT ON TABLE Financial IS '재무 통계';

CREATE UNIQUE INDEX Financial_PK ON Financial
( finno );

SELECT
    finno,
    flowdate,
    reason,
    ftype,
    amount
FROM Financial;

INSERT INTO Financial(finno, flowdate,reason,ftype,amount)
    VALUES(FIN_SEQ.NEXTVAL, TO_DATE('2023/11/05', 'YYYY/MM/DD'),'test',1,10000);
INSERT INTO Financial(finno, flowdate,reason,ftype,amount)
    VALUES(FIN_SEQ.NEXTVAL, TO_DATE('2023/11/06', 'YYYY/MM/DD'),'test1',1,22000);
INSERT INTO Financial(finno, flowdate,reason,ftype,amount)
    VALUES(FIN_SEQ.NEXTVAL, TO_DATE('2023/11/07', 'YYYY/MM/DD'),'test2',0,5000);

commit;