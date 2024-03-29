import styles from './card.module.css';

export default async function Card() {
 
	const cards = await fetch('http://localhost:7254/api/Destino').then(res => res.json());
	console.log(cards);

  return(
   <div className={styles.container}> 
  {cards?.map((card) => (

<div key={card.id} className={styles.card}>
<img src={card.destinoUrl} alt={card.title}/>
<div className={styles.card_title}>
   <p>{card.title}</p>


</div>

</div>
  ))}

   
   </div>
  )
}
