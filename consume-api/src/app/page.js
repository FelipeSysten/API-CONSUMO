import styles from './main.module.css';

export default function Home() {
  return (
    <>
     
     
        <div >
       
        <title>Página principal</title>
        <meta name="keywords" content="Explora, Viajens, Cidades"></meta>
        <meta
          name="description"
          content="Encontre a melhor lugar para você"
        ></meta>
      
      <p>Área Destino</p>
      <h1>Explore Tour - Sua Viagem em primeiro lugar</h1>
      
      <div className={styles.container}>
      <img
        src="/logo.png"
        alt="logo explora"
        width={650}
        height={450}
      />

      </div>
   
        </div>
      
    </>
  )
}
