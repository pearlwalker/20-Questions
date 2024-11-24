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

### If Country is in Africa 
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

### If Country is in America
## FROM #nc1a
  - Does its flag have stars on it?  [is: #nca_stars, from: #nc1a]
    - Yes: Does its flag have more than 3 colors on it? [is: #nca_stars1, from: #nca_stars]   
      - Yes: **Is it Brazil?**  [is: #nca_colors1, from: #nca_stars1]
      - No: **Is it the United States**  [is: #nca_colors0, from: #nca_stars1]
    - No: **Is it Mexico?**  [is: #nca_stars0, from: #nca_stars]
## FROM #nc1b 
  - **Is it Colombia?**  [is: #ncb_guess, from: #nc1b]
## FROM #nc1c
  - Is it one of the 17 “megadiverse” countries?  [is: #ncc_17, from: #nc1c]
    - Yes: Is this country known for its record-setting waterfall? [is: #ncc_171, from: #ncc_17]  
      - Yes: **Is it Venezuela?**  [is: #ncc_waterfall1, from: #ncc_171]
      - No: **Is it Peru?**  [is: #ncc_waterfall0, from: #ncc_171]
    - No: Is its national animal a beaver?  [is: #ncc_170, from: #ncc_17]
      - Yes: **Is it Canada?**  [is: #ncc_beaver1, from: #ncc_170]
      - No: **Is it Argentina?**  [is: #ncc_beaver0, from: #ncc_170]
## FROM #nc1d
- Is it landlocked? [is: #ncd_LL, from: #nc1d]
    - Yes: Does this country have more than one capital?  [is: #ncd_LL1, from: #ncd_LL]
      - Yes: **Is it Bolivia?**  
      - No: **Is it Paraguay?**  
    - No: Is it one of the 17 “megadiverse” countries?  [is: #ncd_LL0, from: #ncd_LL]
      - Yes: **Is it Ecuador?**  [is: #ncd_171, from: #ncd_LL0]
      - No: **Is it Guatemala?**  [is: #ncd_170, from: #ncd_LL0]
## FROM #nc1e
  - **Is it Greenland?** [is: #nd1e_guess, from: #nd1e]

## If Country is in Oceania

## FROM #nd1a  
  - Is its national animal a mythical creature? [is: #nda_mc, from: #nd1a]  
    - Yes: **Is it Indonesia?**  [is: #nda_mc1, from: #nda_mc][is: #n, from: #n]
    - No: **Is it the Philippines?**  [is: #nda_mc0, from: #nda_mc] 
## FROM #nd1b
  - **Is it Australia?**  [is: #ndb_guess, from: #nd1b]
## FROM #nd1c
  - Is it one of the 17 “megadiverse” countries?  [is: #ndc_17, from: #nd1c]
    - Yes: **Is it Papua New Guinea?**  [is: #ndc_171, from: #ndc_17]
    - No: **Is it New Zealand?**  [is: #ndc_170, from: #ndc_17]
## FROM #nd1d
  - **Is it Fiji?** [is: #ndd_guess, from: #nd1d]