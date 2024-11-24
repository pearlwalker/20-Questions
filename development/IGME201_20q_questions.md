Is your country in Eurasia? [is: #n0a]
- Yes: Does your country have a population greater than 100 million people? [is: #na1a, from: #n0a]
  - Yes: [see below]
  - No: Does your country have a population greater than 50 million people? [is: #na1b, from: #n0a]
    - Yes: [see below]
    - No: Does your country have a population greater than 25 million people? [is: #na1c, from: #na1b]

### If Country is in Eurasia
## FROM #na1a
  - Is its national animal a mythical creature?  [is: #naa_mc, from: #na1a]
    - Yes: **Is it Russia?**   [is: #naa_mc1 , from: #naa_mc]
    - No: Is its national animal a tiger?  [is: #naa_mc0 , from: #naa_mc]
      - Yes: Is it one of the 17 “megadiverse” countries? [is: # , from: #naa_mc0]  
        - Yes: **Is it India?**  
        - No: **Is it Bangladesh?**  
      - No: Is it one of the 17 “megadiverse” countries?  [is: # , from: #naa_mc0]
        - Yes: **Is it China?**  
        - No: Does this country have recognized glaciers?  
          - Yes: But does it have…like a lot of glaciers?  
            - Yes: **Is it Pakistan?**  
            - No: **Is it  Japan?**  
          - No: **Is it Vietnam?**  
##  FROM #na1b
  - Is its national animal a mythical creature?  [is: #, from: #na1b]
    - Yes: But like…is it actually that country’s national animal, or is it the national animal of a country within that country?  
      - Yes: **Is it Germany?**  
      - No: **Is it the United Kingdom (England/Scotland/Wales/Northern Ireland)**   
    - No: Is there one of the cardinal directions (North/East/South/West) in the name of this country?   
      - Yes: Did this country operate under Apartheid?  
        - Yes: **Is it South Africa?**  
        - No: **Is it South Korea?**  
      - No: **Is it Iran?**  
## FROM #na1c
  - Is it landlocked?  [is: #, from: #na1c]
    - Yes: Is it “doubly landlocked?”  
      - Yes: **Is it Uzbekistan?**  
      - No: Does its flag have a non-rectangular shape?  
        - Yes: **Is it Nepal?**  
        - No: **Is it Afghanistan?**  
    - No: Is its national animal a mythical creature?  
      - Yes: **Is it North Korea?**  
      - No: Is it one of the 17 “megadiverse” countries?  
        - Yes: **Is it Malaysia?**  
        - No: **Is it Iraq?**

## FROM #na1d
  - Is it landlocked? [is: #, from: #na1d]
    - Yes: Is its national animal a mythical creature?   
      - Yes: Does it have a rainforest?  
        - Yes: **Is it Serbia?**  
        - No: Is it home to the world’s LARGEST ice cave ?  
          - Yes: **Is it Austria?**  
          - No: Is it home to the world’s DEEPEST underwater cave?  
            - Yes: **Is it Czechia?**  
            - No: **Is it Hungary?**
    -  No: Does the name of this country end in \-an?  
        - Yes: Is it in the Caucasus region?   
            - Yes: **Is it Azerbaijan?**  
            - No: **Is it Tajikistan?**  
        - No: Is there anything…unusual about the shape of its flag?  
            - Yes: **Is it Switzerland?**   
            - No: Is its national animal a mythical creature?  
                - Yes: Is it known for its ancient mythology?  
                    - Yes: **Is it Greece?**  
                    - No: **Is it Belgium?**  
                - No: **Is it Hong Kong?**  
## FROM  #na1e
  - Is it landlocked?  [is: #, from: #na1e]
    - Yes: Is it “doubly landlocked”?  
      - Yes: **Is it Liechtenstein?**  
      - No: Is its national animal a mythical creature?  
        - Yes: **Is it Bhutan?**   
        - No: Is its official language Catalan?  
          - Yes: **Is it Andorra?**  
          - No: Is there anything…unusual about the shape of its flag?  
            - Yes: **Is it Vatican City/Holy See?**  
            - No: According to the Köppen climate classification, does this country have an oceanic climate?  
              - Yes: **Is it Luxembourg?**  
              - No: **Is it San Marino?**  
    - No: Does the name of this country begin with the letter ‘M’?  
      - Yes: **Is it Maldives?**  
      - No: **Is it Iceland?**

## If Country is in Africa 

## FROM #nb1a  
  - Is it landlocked?  
    - Yes: **Is it Ethiopia?**  
    - No: Does it have one of the largest film industries in the world?  
      - Yes: **Is it Nigeria?**  
      - No:  Is it one of the 17 “megadiverse” countries?  
        - Yes: **Is it Democratic Republic of Congo?**  
        - No: **Is it Egypt?**  
## FROM #nb1b 
  - Is it landlocked?  
    - Yes: **Is it Uganda?**  
    - No: **Is it Kenya?**  
## FROM #nb1c 
  - Is it landlocked?  
    - Yes: **Is it Niger?**  
    - No: **Is it Algeria?**  
# FROM #nb1d  
  - Is it landlocked?  
    - Yes: **Is it Rwanda?**  
    - No: **Is it Cambodia?**  
## FROM #nb1e
  - **Is it Western Sahara?**

## If Country is in America

- AND population \>100mil (3)  
  - Does its flag have stars on it?  
    - Yes: Does its flag have more than 3 colors on it?   
      - Yes: **Is it Brazil?**  
      - No: **Is it the United States**  
    - No: **Is it Mexico?**  
- AND population \>50mil (1)  
  - **Is it Colombia?**  
- AND population \>25mil (4)  
  - Is it one of the 17 “megadiverse” countries?  
    - Yes: Is this country known for its record-setting waterfall?  
      - Yes: **Is it Venezuela?**  
      - No: **Is it Peru?**  
    - No: Is its national animal a beaver?  
      - Yes: **Is it Canada?**  
      - No: **Is it Argentina?**  
- AND population \>1.1mil (17)  
  - Yes: Does this country have more than one capital?  
    - Yes: **Is it Bolivia?**  
    - No: **Is it Paraguay?**  
  - No: Is it one of the 17 “megadiverse” countries?  
    - Yes: **Is it Ecuador?**  
    - No: **Is it Guatemala?**  
- AND population \<1.1mil (31)  
  - **Is it Greenland?**

## If Country is in Oceania

- AND population \>100mil (2)  
  - Is its national animal a mythical creature?  
    - Yes: **Is it Indonesia?**  
    - No: **Is it the Philippines?**  
- AND population \>25mil (1)  
  - **Is it Australia?**  
- AND population \>1.1mil (2)  
  - Is it one of the 17 “megadiverse” countries?  
    - Yes: **Is it Papua New Guinea?**  
    - No: **Is it New Zealand?**  
- AND population \<1.1mil (19)  
  - **Is it Fiji?**