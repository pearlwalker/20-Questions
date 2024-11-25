Is your country in Eurasia? [is: #n0a]
- Yes: Does your country have a population greater than 100 million people? [is: #na1a, from: #n0a]
  - Yes: [see below]
  - No: Does your country have a population greater than 50 million people? [is: #na1b, from: #n0a]
    - Yes: [see below]
    - No: Does your country have a population greater than 25 million people? [is: #na1c, from: #na1b]
      - Yes: [see below]
      - No: Does your country have a population greater than 1.1 million people? [is: #na1d, from #na1c]
        - Yes: [see below] #na1d
        - No: [see below] #na1e
  - No: Is your country in Africa? [is: #n0b, from #n0a]
    - Yes: Does your country have a population greater than 100 million people? [is: #nb1a, from: #n0b]
      - Yes: [see below]
      - No: Does your country have a population greater than 50 million people? [is: #nb1b, from: #n0b]
        - Yes: [see below]
        - No: Does your country have a population greater than 25 million people? [is: #nb1c, from: #nb1b]
          - Yes: [see below]
          - No: Does your country have a population greater than 1.1 million people? [is: #nb1d, from #nb1c]
            - Yes: [see below] #nb1d
            - No: [see below] #nb1e
    - No: Is your country in the Americas? [is: #n0c, from #n0b]
      - Yes: Does your country have a population greater than 100 million people? [is: #nc1a, from: #n0c]
        - Yes: [see below]
        - No: Does your country have a population greater than 50 million people? [is: #cb1b, from: #n0c]
          - Yes: [see below]
          - No: Does your country have a population greater than 25 million people? [is: #nc1c, from: #nc1b]
            - Yes: [see below]
            - No: Does your country have a population greater than 1.1 million people? [is: #nc1d, from #nc1c]
              - Yes: [see below] #nc1d
              - No: [see below] #nc1e
        - No: Is your country in Oceania? [is: #n0d, from #n0c]
          - Yes: Does your country have a population greater than 100 million people? [is: #nd1a, from: #n0d]
            - Yes: [see below]
              - No: Does your country have a population greater than 25 million people? [is: #nd1b, from: #nd1a]
                - Yes: [see below]
                - No: Does your country have a population greater than 1.1 million people? [is: #nd1c, from #nd1b]
                  - Yes: [see below] #nb1c
                  - No: [see below] #nb1d
          - No: **Is it Anartica?** [is: #n0e, from #n0d] 

### If Country is in Eurasia
## FROM #na1a
  - Is its national animal a mythical creature?  [is: #naa_mc, from: #na1a]
    - Yes: **Is it Russia?**   [is: #naa_mc1, from: #naa_mc]
    - No: Is its national animal a tiger?  [is: #naa_mc0 , from: #naa_mc]
      - Yes: Is it one of the 17 “megadiverse” countries? [is: #naa_tiger1, from: #naa_mc0]  
        - Yes: **Is it India?**  [is: #naa_171, from: #naa_tiger1]
        - No: **Is it Bangladesh?**  [is: #naa_170, from: #naa_tiger1]
      - No: Is it one of the 17 “megadiverse” countries?  [is: # naa_tiger0, from: #naa_mc0]
        - Yes: **Is it China?**  [is: #naa_171, from: #naa_tiger0]
        - No: Does this country have recognized glaciers?  [is: #naa_170, from: #naa_tiger0]
          - Yes: But does it have…like a lot of glaciers?  [is: #naa_glacier1, from: #naa_170]
            - Yes: **Is it Pakistan?**  [is: #naa_glaciers1, from: #naa_glacier1]
            - No: **Is it  Japan?**  [is: #naa_glaciers0, from: #naa_glacier1]
          - No: **Is it Vietnam?**  [is: #naa_glacier0, from: #naa_170]
##  FROM #na1b
  - Is its national animal a mythical creature?  [is: #nab_mc, from: #na1b]
    - Yes: But like…is it actually that country’s national animal or is it the national animal of a country within that country?  [is: #nab_mc1, from: #nab_mc]
      - Yes: **Is it Germany?**  [is: #nab_mcfr1, from: #nab_mc1]
      - No: **Is it the United Kingdom (England/Scotland/Wales/Northern Ireland)** [is: #nab_mcfr0, from: #nab_mc1]   
    - No: Is there one of the cardinal directions (North/East/South/West) in the name of this country?   [is: #nab_mc0, from: #nab_mc]
      - Yes: Did this country operate under Apartheid?  [is: #nab_NESW1, from: #nab_mc0]
        - Yes: **Is it South Africa?**  [is: #nab_apartheid1, from: #nab_NESW1]
        - No: **Is it South Korea?**  [is: #nab_apartheid0, from: #nab_NESW1]
      - No: **Is it Iran?**  [is: #nab_NESW0, from: #nab_mc0]
## FROM #na1c
  - Is it landlocked?  [is: #nac_LL, from: #na1c]
    - Yes: Is it “doubly landlocked?” [is: #nac_LL1, from: #nac_LL] 
      - Yes: **Is it Uzbekistan?**  [is: #nac_2LL1, from: #nac_LL1]
      - No: Does its flag have a non-rectangular shape?  [is: #nac_2LL0, from: #nac_LL1]
        - Yes: **Is it Nepal?**  [is: #nac_weirdflag1, from: #nac_2LL0]
        - No: **Is it Afghanistan?**  [is: #nac_weirdflag0, from: #nac_2LL0]
    - No: Is its national animal a mythical creature? [is: #nac_LL0, from: #nac_LL]  
      - Yes: **Is it North Korea?**   [is: #nac_mc1, from: #nac_LL]
      - No: Is it one of the 17 “megadiverse” countries?  [is: #nac_mc0, from: #nac_LL]
        - Yes: **Is it Malaysia?**  [is: #nac_171, from: #nac_mc0]
        - No: **Is it Iraq?** [is: #nac_170, from: #nac_mc0]

## FROM #na1d  
  - Is it landlocked? [is: #nad_LL, from: #na1d]
    - Yes: Is its national animal a mythical creature? [is: #nad_LL1, from: #nad_LL]   
      - Yes: Is it home to the world’s LARGEST ice cave? [is: #nad_mc1, from: #nad_LL1]  
        - Yes: **Is it Austria?**   [is: #nad_icecave1, from: #nad_mc1]
        - No: Is it home to the world’s DEEPEST underwater cave? [is: #nad_icecave0, from: #nad_mc1]
          - Yes: **Is it Czechia?**  [is: #nad_underwatercave1, from: #nad_icecave0]
          - No: **Is it Hungary?**[is: #nad_underwatercave0, from: #nad_icecave0]
      - No: **Is it Serbia?**  [is: #nad_mc0, from: #nad_LL1] 
    -  No: Does the name of this country end in \-an?  [is: #nad_LL0, from: #nad_LL]   
        - Yes: Is it in the Caucasus region?   [is: #nad_an1, from: #nad_LL0]   
            - Yes: **Is it Azerbaijan?**  [is: #nad_caucasus1, from: #nad_an1]   
            - No: **Is it Tajikistan?**  [is: #nad_caucasus0, from: #nad_an1]   
        - No: **Is it Hong Kong?** [is: #nad_randomguess, from #nad_LL0] 
## FROM  #na1e
  - Is it landlocked?  [is: #nae_LL, from: #na1e]
    - Yes: Is it “doubly landlocked”? [is: #nae_LL1, from: #nae_LL]  
      - Yes: **Is it Liechtenstein?**  [is: #nae_2LL1, from: #nae_LL1]
      - No: Is its national animal a mythical creature?  [is: #nae_2LL0, from: #nae_LL1]
        - Yes: **Is it Bhutan?**   [is: #nae_mc1, from: #nae_2LL0]
        - No: Is its official language Catalan?  [is: #nae_mc0, from: #nae_2LL0]
          - Yes: **Is it Andorra?**  [is: #nae_catalan1, from: #nae_mc0]
          - No: Is there anything…unusual about the shape of its flag?  [is: #nae_catalan0, from: #nae_mc0]
            - Yes: **Is it Vatican City/Holy See?**  [is: #nae_weirdflag1, from: #nae_catalan0]
            - No: According to the Köppen climate classification, does this country have an oceanic climate? [is: #nae_weirdflad0, from: #nae_catalan0]  
              - Yes: **Is it Luxembourg?**  [is: #nae_oceanic1, from: #nae_weirdflag0]
              - No: **Is it San Marino?**  [is: #nae_oceanic0, from: #nae_weirdflag0]
    - No: Does the name of this country begin with the letter ‘M’?  [is: #nae_LL0, from: #nae_LL]
      - Yes: **Is it Maldives?**  [is: #nae_m1, from: #nae_LL0]
      - No: **Is it Iceland?** [is: #nae_m0, from: #nae_LL0]

### If Country is in Africa 
## FROM #nb1a  
  - Is it landlocked?  [is: #nba_LL, from: #nb1a]
    - Yes: **Is it Ethiopia?**  [is: #nba_LL1, from: #nba_LL]
    - No: Does it have one of the largest film industries in the world? [is: #nba_LL0, from: #nba_LL]  
      - Yes: **Is it Nigeria?**  [is: #nba_film1, from: #nba_LL0]
      - No:  Is it one of the 17 “megadiverse” countries? [is:nba_film0 #n, from: #nba_LL0]  
        - Yes: **Is it Democratic Republic of Congo?**  [is: #nba_171, from: #nba_film0]
        - No: **Is it Egypt?**  [is: #nba_170, from: #nba_film0]
## FROM #nb1b 
  - Is it landlocked?  [is: #nbb_LL, from: #nb1b]
    - Yes: **Is it Uganda?**  [is: #nbb_LL1, from: #nbb_LL]
    - No: **Is it Kenya?**  [is: #nbb_LL0, from: #nbb_LL]
## FROM #nb1c 
  - Is it landlocked?  [is: #nbc_LL, from: #nb1c]
    - Yes: **Is it Niger?**  [is: #nbc_LL1, from: #nbc_LL]
    - No: **Is it Algeria?**  [is: #nbc_LL0, from: #nbc_LL]
# FROM #nb1d  
  - Is it landlocked?  [is: #nbd_LL, from: #nb1d]
    - Yes: **Is it Rwanda?**  [is: #nbd_LL1, from: #nbd_LL]
    - No: **Is it Cambodia?**  [is: #nbd_LL0, from: #nbd_LL]
## FROM #nb1e
  - **Is it Western Sahara?** [is: #nbe_guess, from: #nb1e]

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
    - Yes: **Is it Indonesia?**  [is: #nda_mc1, from: #nda_mc]
    - No: **Is it the Philippines?**  [is: #nda_mc0, from: #nda_mc] 
## FROM #nd1b
  - **Is it Australia?**  [is: #ndb_guess, from: #nd1b]
## FROM #nd1c
  - Is it one of the 17 “megadiverse” countries?  [is: #ndc_17, from: #nd1c]
    - Yes: **Is it Papua New Guinea?**  [is: #ndc_171, from: #ndc_17]
    - No: **Is it New Zealand?**  [is: #ndc_170, from: #ndc_17]
## FROM #nd1d
  - **Is it Fiji?** [is: #ndd_guess, from: #nd1d]