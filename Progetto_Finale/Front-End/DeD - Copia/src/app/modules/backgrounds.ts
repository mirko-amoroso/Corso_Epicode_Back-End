const BackgroundArray = [
  {
    nome: "Accolito",
    ideali: [
      "Tradizione. Le antiche tradizioni del culto devono essere preservate e sostenute. (Legale)",
      "Carità. Voglio aiutare chi ha bisogno, qualunque sia il costo personale. (Buono)",
      "Cambiamento. Creare dei nuovi ideali e fedi è più importante di seguire i vecchi dogmi. (Caotico)",
      "Potere. Aspiro a diventare il capo della mia fede, o di un'altra. (Malvagio)",
      "Fede. Confido che il mio dio guiderà le mie azioni. Ho fede che tutto andrà come previsto. (Legale)",
      "Aspirazione. Aspiro alla saggezza divina in tutto quello che faccio. (Neutrale)"
    ],
    tratti_caratteriali: [
      "Sono tollerante nei confronti delle altre fedi e rispetto la devozione sincera degli altri.",
      "Posso trovare un linguaggio comune con chiunque lo voglia discutere di argomenti religiosi.",
      "Presto aiuto a chiunque sia in difficoltà, indipendentemente dal rischio.",
      "Dedico molto tempo alla preghiera e alla meditazione.",
      "Credo fermamente che il mio dio abbia un piano per me e per tutti gli altri.",
      "Sono stato allevato da una comunità religiosa, il che mi rende abile a vivere con poco.",
      "Penso di avere risposte per tutto, e non mi trattengo dal condividerle.",
      "Sono sereno, anche in situazioni di pericolo: credo che il mio dio mi proteggerà."
    ],
    legami: [
      "La mia fede è ciò che mi mantiene saldo contro ogni avversità.",
      "Ognuno di noi è destinato a servire il nostro dio, e io devo guidare gli altri sulla retta via.",
      "Aiuto chiunque, che sia credente o meno, perché tutti meritano compassione.",
      "Cerco di proteggere il tempio del mio dio con tutte le mie forze.",
      "Il mio ordine religioso è la mia vera famiglia, e sono disposto a dare tutto per proteggerlo.",
      "Sarà mio dovere far trionfare la mia fede, a qualsiasi costo."
    ],
    difetti: [
      "Non mi fido di quelli che non condividono la mia fede.",
      "Ritengo che i peccatori meritino di essere puniti in modo severo.",
      "Devo fare dei sacrifici personali per seguire la mia fede.",
      "La mia fede cieca mi fa ignorare qualsiasi prova contraria.",
      "Sono troppo convinto della superiorità del mio dio sugli altri.",
      "Non accetto altre opinioni religiose diverse dalla mia."
    ]
  },
  {
    nome: "Criminale",
    ideali: [
      "Onore. Non rubo dai miei compagni criminali e i codici sono tutto. (Legale)",
      "Libertà. Le catene sono fatte per essere spezzate, come quelle di ogni autorità legittima. (Caotico)",
      "Carità. Aiuto chi non può aiutare se stesso. (Buono)",
      "Vendetta. Non riposo finché chi mi ha offeso non è morto. (Malvagio)",
      "Mistero. Non devo mai rivelare la mia vera identità. (Neutrale)",
      "Perspicacia. Penso sempre tre passi avanti rispetto ai miei avversari. (Neutrale)"
    ],
    tratti_caratteriali: [
      "La prima cosa che faccio in una nuova città è conoscere i suoi criminali.",
      "Ho sempre un piano per ciò che farò quando le cose andranno male.",
      "Sono calmo qualunque cosa accada, e non faccio domande sugli ordini.",
      "La mia volontà è incrollabile e non cedo a nessuna pressione.",
      "Sono sempre pronto a fuggire e mi tengo una via di fuga pronta.",
      "Non ho mai intenzione di lasciarmi incastrare.",
      "Mi piace colpire gli altri con le mie arguzie.",
      "Posso essere molto convincente se voglio ottenere qualcosa."
    ],
    legami: [
      "Sto cercando di tornare da una persona che ho lasciato alle spalle.",
      "La mia fedeltà va verso il mio equipaggio, non importa il costo.",
      "Sono stato tradito da qualcuno di cui mi fidavo, e questo non accadrà mai più.",
      "L'unico motivo per cui non sono stato preso è perché non lascio tracce.",
      "Qualcuno ha preso la caduta per me e mi devo sdebitare.",
      "Sono disposto a fare qualsiasi cosa per ottenere la mia vendetta."
    ],
    difetti: [
      "Se c'è un modo facile per fare qualcosa, lo faccio, anche se è immorale.",
      "Sono avaro con i miei guadagni.",
      "Mi fido solo di me stesso e non mi interessa di chiunque altro.",
      "La vendetta è la mia motivazione principale.",
      "Mi fido troppo delle mie abilità.",
      "Non mi faccio scrupoli ad abbandonare qualcuno se significa salvarmi."
    ]
  },
  {
    nome: "Eroe_Popolare",
    ideali: [
      "Rispetto. Le persone meritano di essere trattate con dignità e rispetto. (Buono)",
      "Equità. Nessuno deve essere trattato in modo diverso, sia dalla legge che dai potenti. (Legale)",
      "Libertà. Il tiranno che incatena la mia gente deve cadere. (Caotico)",
      "Potere. Se posso ottenere il potere, lo userò per proteggere i miei compagni. (Neutrale)",
      "Fede. Credo fermamente che l'unica strada per migliorare il mondo sia attraverso il coraggio. (Qualsiasi)",
      "Onore. La mia gente mi guarda con orgoglio e io non la deluderò. (Qualsiasi)"
    ],
    tratti_caratteriali: [
      "Sono abituato a far fronte a situazioni di tensione e a lavorare sotto pressione.",
      "Non posso fare a meno di aiutare qualcuno in difficoltà, anche se so che mi metterà nei guai.",
      "Sono sempre pronto a combattere per proteggere chi non può difendersi.",
      "Cerco di risolvere le dispute pacificamente, ma non mi tiro indietro se serve combattere.",
      "La mia gente ha sofferto sotto un oppressore e io non permetterò che accada di nuovo.",
      "Cerco sempre di migliorare la mia comunità e di unire la mia gente.",
      "Sono molto protettivo nei confronti di chi mi sta vicino.",
      "Non mi arrendo mai, anche nelle situazioni più disperate."
    ],
    legami: [
      "Proteggo sempre chi non è in grado di difendersi.",
      "Il mio villaggio o comunità è tutto per me, e lo proteggerò con la mia vita.",
      "Sono un eroe popolare per la mia gente e mi sforzo di non deluderli.",
      "Cerco vendetta contro chi ha fatto del male alla mia famiglia o alla mia comunità.",
      "Non dimenticherò mai il sacrificio di qualcuno che mi ha aiutato a diventare un eroe.",
      "La mia gente dipende da me per guidarla verso una vita migliore."
    ],
    difetti: [
      "Non riesco a tollerare l'ingiustizia e reagisco impulsivamente.",
      "Sono incline a mettermi nei guai per difendere gli altri.",
      "A volte prendo decisioni senza pensare alle conseguenze.",
      "Faccio fatica a fidarmi delle persone, specialmente di chi ha più potere.",
      "Il desiderio di vendetta spesso oscura il mio giudizio.",
      "Non so quando fermarmi, anche se potrebbe costarmi caro."
    ]
  },
  {
    nome: "Nobile",
    ideali: [
      "Rispetto. L'obbligo della nobiltà è di proteggere la gente comune. (Buono)",
      "Responsabilità. È mio dovere rispettare la mia posizione. (Legale)",
      "Indipendenza. Non posso permettere che altri decidano per me. (Caotico)",
      "Potere. Se ottengo più potere, posso fare del bene migliore per tutti. (Malvagio)",
      "Famiglia. La mia lealtà va prima di tutto alla mia famiglia. (Neutrale)",
      "Nobile. La nobiltà mi dà il diritto di governare, ma devo farlo con giustizia. (Qualsiasi)"
    ],
    tratti_caratteriali: [
      "La mia famiglia, la mia casa e il mio titolo sono tutto per me.",
      "Non permetto che un insulto contro la mia nobiltà passi senza conseguenze.",
      "Cerco di sembrare sempre al di sopra degli altri.",
      "Mi piace parlare di cose di cui le persone comuni non comprendono l'importanza.",
      "La mia posizione sociale è tutto, e mi aspetto che gli altri mi trattino con il giusto rispetto.",
      "Sono stato addestrato nelle arti diplomatiche e sono bravo nel trattare con persone di tutti i ceti.",
      "Non permetto mai che una sfida resti senza risposta.",
      "Sembro sempre il migliore nella stanza, o almeno ci provo."
    ],
    legami: [
      "La mia famiglia nobile è tutto ciò che mi rimane.",
      "Sarò ricordato come il più grande tra i nobili della mia casata.",
      "L'onore della mia famiglia è una cosa a cui non posso rinunciare.",
      "Qualcuno ha minacciato la mia famiglia e cercherò vendetta a qualunque costo.",
      "La mia casata è sempre stata la più grande della regione, e io devo mantenerne la reputazione.",
      "Mi dedico completamente al mio casato e alla sua prosperità."
    ],
    difetti: [
      "Sono arrogante e penso che nessuno sia alla mia altezza.",
      "Mi aspetto che tutti rispettino la mia autorità senza discussione.",
      "Non riesco a gestire il fallimento e faccio tutto per evitarlo.",
      "La mia famiglia e il nostro potere sono tutto per me.",
      "Non posso accettare un insulto e farò tutto il possibile per vendicarmi.",
      "Cerco sempre di apparire migliore di chiunque altro, anche se ciò mi rende antipatico."
    ]
  },
  {
  nome: "Forestiero",
    ideali: [
      "Cambiamento. La vita è come le stagioni, in costante cambiamento, e noi dobbiamo cambiare con essa. (Caotico)",
      "Rispetto. La natura è più grande di tutte le creature viventi e merita rispetto. (Neutrale)",
      "Perseveranza. Sopravviverò, qualunque siano le avversità. (Neutrale)",
      "Potere. Sfrutto la potenza della natura per dominare gli altri. (Malvagio)",
      "Vita. La vita è sacra e deve essere preservata. (Buono)",
      "Libertà. Non sarò mai incatenato dalla civilizzazione. (Caotico)"
    ],
    tratti_caratteriali: [
      "Sono guidato da un grande amore per la natura, e cerco di proteggere il mondo naturale.",
      "Non sono abituato alla civilizzazione e tendo ad evitare le città e le folle.",
      "Mi adatto rapidamente a nuove situazioni, anche se sono pericolose o difficili.",
      "Sono molto protettivo nei confronti delle creature selvagge e del loro habitat.",
      "Preferisco risolvere i problemi con soluzioni pratiche piuttosto che filosofare.",
      "Sono molto silenzioso e solitario, parlo solo quando necessario.",
      "Ho un legame profondo con la natura e mi sento a casa solo all'aperto.",
      "Sono diffidente verso la civilizzazione e le sue tecnologie."
    ],
    legami: [
      "Il mio gruppo tribale o comunità è tutto per me, e farò di tutto per proteggerli.",
      "Sono devoto alla natura e la difenderò contro chiunque tenti di distruggerla.",
      "Ho perso tutto a causa di una catastrofe naturale, e ora cerco di prevenire altre tragedie.",
      "Il mio spirito è legato a una specifica regione selvaggia che devo proteggere a ogni costo.",
      "Sono stato tradito da un compagno e cerco vendetta.",
      "La natura è mia madre e farò di tutto per preservarla, anche a costo della mia vita."
    ],
    difetti: [
      "Sono lento a fidarmi degli altri e sospetto di chiunque provenga dalla città.",
      "Sono rigido nelle mie convinzioni e non tollero opinioni contrarie.",
      "Non riesco a capire la cultura urbana e mi sento a disagio in ambienti civilizzati.",
      "Sono troppo legato alla natura e faccio fatica a interagire con le persone.",
      "Non riesco a lasciarmi alle spalle un insulto contro la natura, reagisco impulsivamente.",
      "Credo che la natura sia superiore all'umanità e guardo dall'alto in basso chi vive in città."
    ]
  },
  {
    nome: "Marinaio",
    ideali: [
      "Rispetto. Il mare è una forza da rispettare e obbedire. (Neutrale)",
      "Libertà. Il mare è la via verso la libertà, non ci sono catene sull'oceano. (Caotico)",
      "Onore. Il mio equipaggio è la mia famiglia e farò di tutto per proteggerli. (Legale)",
      "Fama. La mia impresa marittima sarà ricordata da tutti. (Qualsiasi)",
      "Ricchezza. Navigo per arricchirmi, qualunque sia il costo. (Malvagio)",
      "Avventura. La vita in mare è un'avventura continua, e io vivo per questo. (Caotico)"
    ],
    tratti_caratteriali: [
      "Parlo costantemente del mare, delle sue meraviglie e dei suoi pericoli.",
      "Ho una storia incredibile da raccontare su ogni porto in cui sono stato.",
      "Non mi fido facilmente, ma una volta guadagnata la mia fiducia, sono un amico leale.",
      "Sono molto scaramantico riguardo al mare e seguo rituali precisi prima di ogni viaggio.",
      "Non posso fare a meno di seguire il richiamo del mare. Mi sento soffocato sulla terraferma.",
      "Sono molto abile nel lavorare in squadra e metto sempre l'equipaggio al primo posto.",
      "Non mi abbatto mai e cerco di sollevare il morale degli altri in situazioni difficili.",
      "Sono sempre alla ricerca di nuove rotte e avventure in mari inesplorati."
    ],
    legami: [
      "Il mio vecchio equipaggio è come una famiglia per me, farei qualsiasi cosa per loro.",
      "Ho un ricordo speciale di un porto dove ho vissuto una grande avventura, e voglio tornare lì.",
      "Un pirata ha tradito il mio equipaggio, e cercherò vendetta su di lui.",
      "Una volta ho perso una nave a causa di una tempesta, e cerco di riottenere ciò che ho perso.",
      "Il mare è il mio unico vero amore, e farò di tutto per proteggere la sua bellezza e potenza.",
      "Devo una grande somma di denaro a un ricco mercante, e sto cercando di saldare il mio debito."
    ],
    difetti: [
      "Sono incline a bere troppo e a lasciarmi andare quando sono a terra.",
      "Non riesco a resistere alla tentazione di sfidare la sorte, anche quando è rischioso.",
      "Non mi fido di nessuno che non sia un marinaio.",
      "Sono sempre alla ricerca di tesori nascosti, anche a costo di mettere a rischio la mia vita.",
      "Non posso evitare di vanificare i miei guadagni in feste e bagordi ogni volta che torno a terra.",
      "Sono troppo sicuro delle mie capacità in mare e tendo a sottovalutare i pericoli."
    ]
  },
  {
    nome: 'Soldato',
    ideali: [
      'Rispetto. Tratto i miei compagni con rispetto.',
      'Onore. Non abbandonerò mai una sfida onorevole.',
      'Vittoria. La vittoria è l’unico fine per cui combattere.',
      'Sicurezza. I miei compagni devono sopravvivere.',
      'Nazionalismo. La mia patria è tutto ciò che conta.',
      'Disciplina. Il duro lavoro e l’addestramento sono l’unica via per l’onore.'
    ],
    trattiCaratteriali: [
      'Sono sempre cortese e professionale.',
      'Mi piace essere ammirato per le mie capacità.',
      'Ho uno strano senso dellumorismo in battaglia.',
      'Sono ossessionato dalle storie di guerre e battaglie passate.',
      'Sono abituato a seguire ordini e aspettarmi lo stesso dagli altri.',
      'Tengo sempre la mia attrezzatura in perfetto stato.'
    ],
    legami: [
      'Combatterò per proteggere la mia patria, qualunque sia il prezzo.',
      'Mi prenderò cura della mia famiglia, anche a costo della mia vita.',
      'Il mio vecchio comandante è il mio mentore e farò di tutto per impressionarlo.',
      'Ho un’arma ereditata che considero un simbolo del mio passato.',
      'Porto il peso del mio passato, e questo mi spinge a migliorare.',
      'Non abbandonerò mai un compagno in battaglia, anche a costo della vita.'
    ],
    difetti: [
      'Non riesco a tollerare una sconfitta.',
      'Tendo a diventare violento quando vengo provocato.',
      'Ho abbandonato una battaglia una volta e ancora mi perseguita.',
      'Sono ossessionato dall’idea di dimostrare il mio valore.',
      'Penso che ogni problema possa essere risolto con la forza.',
      'Porto rancore per vecchi nemici.'
    ]
  },
  // Intrattenitore
  {
    nome: 'Intrattenitore',
    ideali: [
      'Bellezza. Quando eseguo la mia arte, rendo il mondo un luogo migliore.',
      'Tradizione. Larte deve essere conservata e praticata.',
      'Creatività. Perseguo lispirazione ovunque mi porti.',
      'Libertà. Larte è espressione libera e personale.',
      'Gloria. Il riconoscimento e la fama sono il mio obiettivo.',
      'Comunità. La mia arte serve ad elevare la mia gente.'
    ],
    trattiCaratteriali: [
      'Amo fare battute e far ridere la gente.',
      'Sono sempre pronto a esibirmi.',
      'Esagero ogni mia storia o esperienza.',
      'Uso metafore esagerate quando parlo.',
      'Ho un repertorio infinito di battute.',
      'Faccio del mio meglio per impressionare chi mi ascolta.'
    ],
    legami: [
      'Il mio strumento musicale è il mio più grande tesoro.',
      'Amo la mia troupe come una famiglia.',
      'Sono leale alla mia gilda di artisti.',
      'Un fan o mecenate è il mio più grande sostenitore.',
      'Ho una rivalità con un altro artista.',
      'Il palco è l’unico posto dove mi sento veramente vivo.'
    ],
    difetti: [
      'Non riesco a tollerare le critiche.',
      'Sono vanitoso e cerco sempre di essere al centro dell’attenzione.',
      'Sono sempre alla ricerca di un pubblico per le mie performance.',
      'Ho un debole per le lodi e i complimenti.',
      'A volte mi lascio prendere troppo dal mio personaggio.',
      'Sono incapace di prendere le cose seriamente.'
    ]
  },
  // Eremita
  {
    nome: 'Eremita',
    ideali: [
      'Conoscenza. La mia ricerca della verità è infinita.',
      'Solitudine. La mia pace interiore si trova solo nella solitudine.',
      'Protezione. Il mio isolamento serve a proteggere gli altri.',
      'Scoperta. Voglio scoprire i segreti dell’universo.',
      'Natura. La natura è la mia guida e il mio rifugio.',
      'Evoluzione. Il cambiamento è la chiave per la crescita personale.'
    ],
    trattiCaratteriali: [
      'Amo la solitudine e il silenzio.',
      'Sono molto riflessivo e parlo solo quando necessario.',
      'Cerco la verità sopra ogni altra cosa.',
      'Mi sento a disagio in mezzo alla folla.',
      'Valuto attentamente ogni decisione che prendo.',
      'Cerco il significato profondo di tutto ciò che mi circonda.'
    ],
    legami: [
      'Un segreto oscuro mi ha portato a vivere in isolamento.',
      'Mi sento responsabile di una conoscenza che potrebbe distruggere il mondo.',
      'Ho una profonda connessione con un luogo sacro nella natura.',
      'Il mio passato mi perseguita, e vivo in isolamento per sfuggirvi.',
      'Ho lasciato tutto dietro di me per seguire la mia vocazione spirituale.',
      'La mia solitudine mi ha portato a scoprire qualcosa di profondo e pericoloso.'
    ],
    difetti: [
      'Non riesco a tollerare il rumore e la confusione delle città.',
      'La mia visione del mondo è diventata distorta a causa dell’isolamento.',
      'Sono eccessivamente paranoico riguardo ai pericoli del mondo esterno.',
      'Credo di avere una missione superiore e guardo gli altri dall’alto in basso.',
      'Mi sono staccato emotivamente dalle persone.',
      'Ho difficoltà a fidarmi degli altri dopo tanto isolamento.'
    ]
  },
  {
    nome: 'Artigiano_di_Gilda',
    ideali: [
      'Comunità. Le persone che condividono la mia professione sono la mia vera famiglia.',
      'Generosità. Il mio talento è fatto per arricchire tutti, non solo me stesso.',
      'Libertà. Ognuno dovrebbe essere libero di vivere come preferisce.',
      'Onestà. Non baratto mai la qualità del mio lavoro per denaro o comodità.',
      'Onore. Il mio mestiere è la mia vita, e devo esercitarlo con onore.',
      'Autoconservazione. La mia priorità è mantenere viva la mia attività.'
    ],
    trattiCaratteriali: [
      'Sono orgoglioso del mio mestiere e del mio talento.',
      'Mi piace parlare del mio lavoro e insegnare agli altri.',
      'Sono meticoloso e perfezionista in ogni dettaglio.',
      'Odio quando le persone sottovalutano l’importanza del mio lavoro.',
      'Tengo sempre un occhio sulle opportunità di guadagno.',
      'Sono un duro lavoratore e mi aspetto lo stesso dagli altri.'
    ],
    legami: [
      'Sono leale alla mia gilda e difenderò i suoi interessi.',
      'Ho una bottega o un’attività che è tutto per me.',
      'Il mio maestro mi ha insegnato tutto quello che so, e farò di tutto per onorare la sua memoria.',
      'Devo tutto a un cliente importante che mi ha dato una grande opportunità.',
      'Ho una famiglia da mantenere con il mio lavoro.',
      'Un concorrente mi ha rovinato una volta, e non mi riposerò finché non avrò vendetta.'
    ],
    difetti: [
      'Sono ossessionato dal denaro e dalle ricchezze.',
      'A volte antepongo il lavoro alla mia famiglia e agli amici.',
      'Sono un perfezionista e non accetto niente che non sia perfetto.',
      'Odio chiunque metta in dubbio la mia competenza professionale.',
      'Ho un debito con un importante cliente o mercante.',
      'Sono estremamente competitivo e non sopporto che qualcuno sia migliore di me nel mio campo.'
    ]
  },
  // Ciarlatano
  {
    nome: 'Ciarlatano',
    ideali: [
      'Indipendenza. Mi piace fare le cose a modo mio, senza seguire le regole.',
      'Lealtà. Non tradisco mai chi mi sta a cuore, anche se sono pronto a ingannare gli altri.',
      'Creatività. Sempre un nuovo trucco, sempre una nuova storia.',
      'Libertà. Niente è più importante della mia libertà di agire come voglio.',
      'Redenzione. Sto cercando di cambiare la mia vita e lasciare il crimine dietro di me.',
      'Potere. Voglio il potere e la ricchezza, non importa a che prezzo.'
    ],
    trattiCaratteriali: [
      'Sono un bugiardo nato e ho una risposta per tutto.',
      'Sono affascinante e riesco sempre a convincere la gente.',
      'Mi piace creare false identità e interpretare diversi ruoli.',
      'Ho sempre una storia incredibile da raccontare.',
      'Sono un maestro della manipolazione e mi piace giocare con gli altri.',
      'Sono sempre attento alle opportunità di inganno e truffa.'
    ],
    legami: [
      'Ho una complice o partner che mi è estremamente leale.',
      'Un tempo ho truffato la persona sbagliata e ora sono costantemente in fuga.',
      'Sono legato a una rete di criminali che mi forniscono supporto e informazioni.',
      'Ho lasciato una vita di inganni per qualcuno che amo.',
      'Porto sempre con me un ricordo del mio più grande colpo.',
      'Sono ossessionato dallidea di riuscire a truffare una persona potente o famosa.'
    ],
    difetti: [
      'Non posso fare a meno di mentire, anche quando sarebbe più facile dire la verità.',
      'Mi piace rischiare e spesso corro troppi rischi.',
      'Sono vanitoso e penso di essere più furbo di chiunque altro.',
      'Non riesco a resistere alla tentazione di un buon colpo.',
      'Non riesco a smettere di raccontare bugie anche quando non necessario.',
      'Mi fido troppo delle mie capacità di convincere gli altri.'
    ]
  },
  // Monello
  {
    nome: 'Monello',
    ideali: [
      'Rispetto. Io rispetto chi rispetta me. La strada non è per i deboli.',
      'Libertà. La strada mi ha insegnato che nessuno può mettere catene alla mia libertà.',
      'Redenzione. Sto cercando di lasciare il passato criminale alle spalle.',
      'Ambizione. Voglio lasciare il mio segno nel mondo, a qualunque costo.',
      'Potere. La vita di strada mi ha insegnato che il potere è tutto.',
      'Sopravvivenza. L’unica cosa che conta è sopravvivere, non importa come.'
    ],
    trattiCaratteriali: [
      'Sono un sopravvissuto, faccio sempre quello che è necessario per cavarmela.',
      'Mi piace scherzare e prendere in giro gli altri, soprattutto chi è più ricco o potente di me.',
      'Sono un tipo silenzioso e osservatore, noto ogni minimo dettaglio.',
      'Non mi fido di nessuno, ma sono leale a chi mi aiuta.',
      'Sono sempre pronto a scappare o a nascondermi se le cose vanno male.',
      'Ho imparato a cavarmela con poco e ad essere creativo nelle soluzioni.'
    ],
    legami: [
      'Ho una banda o un gruppo di amici che considero la mia famiglia.',
      'Sono alla ricerca di un vecchio mentore che mi ha abbandonato quando ero piccolo.',
      'Devo un favore a un potente signore del crimine che una volta mi ha aiutato.',
      'La strada è la mia casa, e farò di tutto per proteggerla.',
      'Ho un legame speciale con qualcuno che mi ha aiutato nei miei giorni più bui.',
      'Sono perseguitato da qualcuno che ho tradito, e continuo a guardarmi le spalle.'
    ],
    difetti: [
      'Sono troppo orgoglioso per chiedere aiuto, anche quando ne ho bisogno.',
      'Non riesco a fidarmi di nessuno completamente, nemmeno dei miei amici più stretti.',
      'Ho un temperamento esplosivo e non ci penso due volte prima di scatenarmi.',
      'Ho sempre in mente uno schema per arricchirmi rapidamente, anche se rischioso.',
      'Non riesco a resistere alla tentazione di sfidare l’autorità.',
      'Sono abituato a fare promesse che non ho intenzione di mantenere.'
    ]
  },
  // Sapiente
  {
    nome: 'Sapiente',
    ideali: [
      'Conoscenza. Il percorso verso la verità è la cosa più importante.',
      'Bellezza. La ricerca della conoscenza è una forma d’arte.',
      'Scoperta. La mia missione è scoprire il nuovo e l’ignoto.',
      'Redenzione. Voglio usare la mia conoscenza per migliorare il mondo.',
      'Potere. La conoscenza è potere, e io voglio ottenerlo.',
      'Logica. La verità risiede nella logica e nella ragione, non nelle emozioni.'
    ],
    trattiCaratteriali: [
      'Sono sempre immerso in un libro o una ricerca.',
      'Ho una curiosità insaziabile e devo sapere tutto.',
      'Sono pronto a mettere in discussione ogni verità accettata.',
      'Mi piace condividere la mia conoscenza con gli altri, a volte troppo.',
      'Sono molto metodico e preciso in tutto ciò che faccio.',
      'Credo che la conoscenza debba essere libera e accessibile a tutti.'
    ],
    legami: [
      'Il mio mentore è la persona più importante della mia vita.',
      'Ho una libreria o un laboratorio che contiene tutto il mio lavoro.',
      'Cè un mistero irrisolto che sto cercando di risolvere da anni.',
      'Sono in debito con un benefattore che ha finanziato la mia educazione.',
      'La mia ricerca ha messo in pericolo qualcuno a cui tengo, e ora devo proteggerlo.',
      'Ho un rivale accademico che mi spinge a migliorare continuamente.'
    ],
    difetti: [
      'Sono eccessivamente critico nei confronti degli altri.',
      'Sono convinto di avere sempre ragione e difficilmente ascolto gli altri.',
      'Sono troppo curioso, e a volte ciò mi mette nei guai.',
      'Sono arrogante riguardo alla mia conoscenza e mi sento superiore agli altri.',
      'Ho labitudine di sottovalutare i problemi pratici, concentrandomi troppo sulla teoria.',
      'Sono ossessionato dalla mia ricerca, a volte trascurando tutto il resto.'
    ]
  }
];
export default BackgroundArray

